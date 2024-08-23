﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> CourseExistsAsync(int courseId)
        {
            return await (_context.Courses.AnyAsync(c => c.Id == courseId));

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

        public async Task<IEnumerable<TeeTime>> GetTeeTimesAsync(int courseId)
        {
            return await _context.TeeTimes
                .Where(t => t.CourseId == courseId).ToListAsync();
        }

        public async Task AddTeeTimeToCourseAsync(int courseId, TeeTime teeTime)
        {
            var course = await GetCourseAsync(courseId, false);
            if (course != null) {
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
