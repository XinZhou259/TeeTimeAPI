using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeeTimeAPI.DbContexts;
using TeeTimeAPI.Entities;

namespace TeeTimeAPI.Services
{
    public class CourseInfoRepository : ICourseInfoRepository
    {
        private readonly CourseInfoContext _context;

        public CourseInfoRepository(CourseInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _context.Courses.OrderBy(c => c.CourseName).ToListAsync();
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync(string? courseName, string? searchQuery)
        {
            if (string.IsNullOrEmpty(courseName) && string.IsNullOrEmpty(searchQuery))
            {
                return await GetCoursesAsync();
            }
            //explicitly cast the courses colletion to IQueryable to use the LINQ method and support differed execution
            //(execute the SQL query after all querys are build up in stage)
            var courseCollection = _context.Courses as IQueryable<Course>;
            if (!string.IsNullOrEmpty(courseName))
            {
                courseName = courseName.Trim();
                courseCollection = courseCollection.Where(c => c.CourseName == courseName);
            }

            if (!string.IsNullOrEmpty(searchQuery))
            {
                searchQuery = searchQuery.Trim();
                courseCollection = courseCollection
                    .Where(c => c.CourseName.Contains(searchQuery) || c.CourseURL.Contains(searchQuery));
            }

            return await courseCollection.OrderBy(c => c.CourseName).ToListAsync();



        }

        public async Task<Course?> GetCourseAsync(int courseId, bool includeTeeTime)
        {
            if (includeTeeTime)
            {
                return await _context.Courses.Include(c => c.TeeTimes)
                    .Where(c => c.Id == courseId).FirstOrDefaultAsync();
            }
            return await _context.Courses
                .Where(c => c.Id == courseId).FirstOrDefaultAsync();
        }

        public async Task<bool> CourseExistsAsync(int courseId)
        {
            return await (_context.Courses.AnyAsync(c => c.Id == courseId));

        }

        public async Task<bool> teeTimesExistAsync(int courseId)
        {
            return await _context.TeeTimes.AnyAsync(t => t.CourseId == courseId);
        }

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            _context.Courses.Remove(course);
        }

        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<TeeTime?> GetTeeTimeAsync(int courseId, int teeTimeId)
        {
            //Task.Delay(1000).Wait();
            return await _context.TeeTimes
                .Where(t => t.CourseId == courseId && t.Id == teeTimeId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TeeTime>> GetTeeTimesAsync(
            int courseId, DateTime? date, TimeSpan? startTime, TimeSpan? endTime)
        {
            var collection = _context.TeeTimes.Where(t => t.CourseId == courseId) as IQueryable<TeeTime>;

            if (date.HasValue)
            {
                collection = collection.Where(t => t.Date.Date == date.Value.Date);
            }


            var teeTimes = await collection.ToListAsync();

            if (startTime.HasValue && endTime.HasValue)
            {
                teeTimes = teeTimes.Where(t => t.Time >= startTime && t.Time <= endTime).ToList();
            }


            return teeTimes;
        }

        public async Task<(IEnumerable<TeeTime>, PaginationMetadata)> GetTeeTimesPagedAsync(
            int courseId, DateTime? date, int currentPage, int pageSize)
        {
            var collection = _context.TeeTimes.Where(t => t.CourseId == courseId) as IQueryable<TeeTime>;

            if (date.HasValue)
            {
                collection = collection.Where(t => t.Date.Date == date.Value.Date);
            }



            var totalItemCount = await collection.CountAsync();

            var paginationMetadata = new PaginationMetadata(totalItemCount, pageSize, currentPage);

            var collectionToReturn = await collection
                .Skip(pageSize * (currentPage - 1))
                .Take(pageSize)
                .ToListAsync();

            return (collectionToReturn, paginationMetadata);
        }

        public async Task AddTeeTimeToCourseAsync(int courseId, TeeTime teeTime)
        {
            var course = await GetCourseAsync(courseId, false);
            if (course != null)
            {
                course.TeeTimes.Add(teeTime);
            }
        }

        public async Task AddTeeTimesToCourseAsync(int courseId, IEnumerable<TeeTime> teeTimes)
        {
            var course = await GetCourseAsync(courseId, false);
            if (course != null)
            {
                foreach (var teeTime in teeTimes)
                {
                    course.TeeTimes.Add(teeTime);
                }

            }
        }
    }
}
