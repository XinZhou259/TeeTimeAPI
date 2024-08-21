using TeeTimeAPI.Entities;

namespace TeeTimeAPI.Services
{
    public interface ICourseInfoRepository
    {
        Task<IEnumerable<Course>> GetCoursesAsync();
        Task<Course?> GetCourseAsync(int courseId, bool includeTeeTime);

        Task<IEnumerable<TeeTime>> GetTeeTimesAsync(int courseId);

        Task<TeeTime?> GetTeeTimeAsync(int courseId, int teeTimeId);
    }
}
