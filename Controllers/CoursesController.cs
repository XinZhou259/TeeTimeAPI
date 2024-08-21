using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TeeTimeAPI.Models;
using TeeTimeAPI.Services;

namespace TeeTimeAPI.Controllers
{
    [ApiController]
    [Route("/courses")]
    public class CoursesController: ControllerBase
    {
        private readonly ICourseService courseService;
        
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CourseDto>> GetCourses()
        {
            //return Ok(CoursesDataStore.Current.Courses);                
            return Ok(courseService.GetCourses());
        }

        [HttpGet("{id}", Name = "GetCourse")]
        public ActionResult<CourseDto> GetCourse(int id)
        {
            var courseToReturn = courseService.GetCourse(id);
            if (courseToReturn == null)
            {
                return NotFound();
            }
            return Ok(courseToReturn);
        }

        [HttpPost]
        public ActionResult<CourseDto> CreateCourse(CourseForCreateDto course)
        {
            
            var courseToCreate = courseService.CreateCourse(course);

           return CreatedAtRoute("GetCourse", new { id = courseToCreate.Id }, courseToCreate);
          
        }

        [HttpPatch("{id}")]
        public ActionResult PartiallyUpdateCourse(int id, JsonPatchDocument<CourseForUpdateDto> patchDocument)
        {
            var courseFromStore = courseService.GetCourse(id);
            if ( courseFromStore == null)
            {
                return NotFound();
            }

            var courseToPatch = new CourseForUpdateDto()
            {
                CourseName = courseFromStore.CourseName,
                CourseUrl = courseFromStore.CourseURL
            };

            patchDocument.ApplyTo(courseToPatch, ModelState);
            //Here the ModelState verify the input model, which is a JsonPatchDocument,as long as the JsonPatchDocument is valid, it will be executed.(e.g. if provide a invalid path, it will return BadRequest error.)
            //Which means even if we write a remove courseName opration in the patch document, it will work, but it's not correct to our business rull, because courseName is required.
            //So we need further validation to match the rules in CourseForUpdateDto.
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(courseToPatch))
            {
                return BadRequest(ModelState);
            }

            var updatedCourse = courseService.UpdateCourse(id, courseToPatch);
            return Ok(updatedCourse);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id)
        {
            var courseToDelete = courseService.GetCourse(id);
            if (courseToDelete == null)
            {
                return NotFound();
            }
            courseService.DeleteCourse(id);
            return NoContent();
        }
    }
}
