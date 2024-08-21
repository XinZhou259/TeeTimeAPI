using TeeTimeAPI.Models;

namespace TeeTimeAPI.Services
{
    public class CourseService : ICourseService
    {
        private CoursesDataStore _coursesDataStore;

        public CourseService()
        {
            _coursesDataStore = new CoursesDataStore();
        }
        public CourseDto CreateCourse(CourseForCreateDto course)
        {
            var courseToCreate = new CourseDto
            {
                Id = _coursesDataStore.Courses.Max(c => c.Id) + 1,
                CourseName = course.CourseName,
                CourseURL = course.CourseUrl
            };
            _coursesDataStore.Courses.Add(courseToCreate);

            return courseToCreate;
        }

        public IEnumerable<CourseDto> GetCourses()
        {
            return _coursesDataStore.Courses;
        }

        public CourseDto GetCourse(int id)
        {
            var course = _coursesDataStore.Courses.FirstOrDefault(c => c.Id == id);            
            return course;
         
        }

        public CourseDto UpdateCourse(int id, CourseForUpdateDto course)
        {
           var courseToUpdate = GetCourse(id);

            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CourseURL = course.CourseUrl;

            return courseToUpdate;
        }

        public void DeleteCourse(int id)
        {
            var courseToDelete = GetCourse(id);
            _coursesDataStore.Courses.Remove(courseToDelete);
        }

       
    }
}
