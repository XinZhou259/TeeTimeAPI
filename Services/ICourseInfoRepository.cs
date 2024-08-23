using TeeTimeAPI.Entities;

namespace TeeTimeAPI.Services
{
    public interface ICourseInfoRepository
    {
        Task<IEnumerable<Course>> GetCoursesAsync();
        Task<Course?> GetCourseAsync(int courseId, bool includeTeeTime);

        Task<bool> CourseExistsAsync(int courseId);

        void AddCourse(Course course);

        void DeleteCourse(Course course);

        Task<bool> SaveChangeAsync();
        Task<IEnumerable<TeeTime>> GetTeeTimesAsync(int courseId);

        Task<TeeTime?> GetTeeTimeAsync(int courseId, int teeTimeId);

        Task AddTeeTimeToCourseAsync(int courseId, TeeTime teeTime);

        Task AddTeeTimesToCourseAsync(int courseId, IEnumerable<TeeTime> teeTimes);
    }
}
