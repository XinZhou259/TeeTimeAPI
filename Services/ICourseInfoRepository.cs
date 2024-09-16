using TeeTimeAPI.Entities;

namespace TeeTimeAPI.Services
{
    public interface ICourseInfoRepository
    {
        Task<IEnumerable<Course>> GetCoursesAsync();

        Task<IEnumerable<Course>> GetCoursesAsync(string? courseName, string? searchQuery);
        Task<Course?> GetCourseAsync(int courseId, bool includeTeeTime);

        Task<bool> CourseExistsAsync(int courseId);

        void AddCourse(Course course);

        void DeleteCourse(Course course);

        Task<bool> SaveChangeAsync();
        Task<bool> teeTimesExistAsync(int courseId);
        Task<(IEnumerable<TeeTime>, PaginationMetadata)> GetTeeTimesPagedAsync(
            int courseId, DateTime? date, int currentPage, int pageSize);
        Task<IEnumerable<TeeTime>> GetTeeTimesAsync(int courseId, DateTime? date, TimeSpan? startTime, TimeSpan? endTime);

        Task<TeeTime?> GetTeeTimeAsync(int courseId, int teeTimeId);

        Task AddTeeTimeToCourseAsync(int courseId, TeeTime teeTime);

        Task AddTeeTimesToCourseAsync(int courseId, IEnumerable<TeeTime> teeTimes);
    }
}
