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


        public async Task<TeeTime?> GetTeeTimeAsync(int courseId, int teeTimeId)
        {
            return await _context.TeeTimes
                .Where(t => t.CourseId == courseId && t.Id == teeTimeId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TeeTime>> GetTeeTimesAsync(int courseId)
        {
            return await _context.TeeTimes
                .Where(t => t.CourseId == courseId).ToListAsync();
        }
    }
}
