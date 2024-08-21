using TeeTimeAPI.Models;

namespace TeeTimeAPI.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseDto> GetCourses();
        CourseDto? GetCourse(int id);
        
        CourseDto CreateCourse(CourseForCreateDto course);

        CourseDto UpdateCourse(int id, CourseForUpdateDto course);

        void DeleteCourse(int id);

       
    }
}
