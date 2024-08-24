using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeeTimeAPI.Models;
using TeeTimeAPI.Services;

namespace TeeTimeAPI.Controllers
{
    [ApiController]
    [Route("/courses")]
    public class CoursesController : ControllerBase
    {

        private ICourseInfoRepository _courseInfoRepository;
        private IMapper _mapper;

        public CoursesController(ICourseInfoRepository courseInfoRepository, IMapper mapper)
        {
            _courseInfoRepository = courseInfoRepository ?? throw new ArgumentNullException(nameof(courseInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCourses(
            [FromQuery(Name = "name")] string? courseName, 
            [FromQuery(Name = "search")] string? searchQuery )
        {
            var courseEntities = await _courseInfoRepository.GetCoursesAsync(courseName, searchQuery);

            return Ok(_mapper.Map<IEnumerable<CourseDto>>(courseEntities));
        }

        [HttpGet("{courseId}", Name = "GetCourse")]
        public async Task<IActionResult> GetCourse(int courseId, bool includeTeeTime = false)
        {
            var course = await _courseInfoRepository.GetCourseAsync(courseId, includeTeeTime);
            if (course == null)
            {
                return NotFound();
            }

            if (includeTeeTime)
            {
                return Ok(_mapper.Map<CourseWithTeeTimeDto>(course));
            }

            return Ok(_mapper.Map<CourseDto>(course));
        }

        [HttpPost]
        public async Task<ActionResult<CourseDto>> CreateCourse(CourseForCreateDto course)
        {
            
            var courseToCreate = _mapper.Map<Entities.Course>(course);
            _courseInfoRepository.AddCourse(courseToCreate);
            await _courseInfoRepository.SaveChangeAsync();
            var courseToReturn =_mapper.Map<CourseDto>(courseToCreate);

            return CreatedAtRoute("GetCourse", new { courseId = courseToReturn.Id }, courseToReturn);

        }

        [HttpPut("{courseId}")]
        public async Task<ActionResult> UpdateCourse(int courseId, CourseForUpdateDto courseForUpdateDto)
        {
            
            if (!await _courseInfoRepository.CourseExistsAsync(courseId))
            {
                return NotFound();
            }
            var courseToUpdate = await _courseInfoRepository.GetCourseAsync(courseId, false);
            _mapper.Map(courseForUpdateDto, courseToUpdate);
            await _courseInfoRepository.SaveChangeAsync();
            return NoContent();
        }

        [HttpDelete("{courseId}")]
        public async Task<ActionResult> DeleteCourse(int courseId)
        {
           
            if (!await _courseInfoRepository.CourseExistsAsync(courseId))
            {
                return NotFound();
            }
            var courseToDelete = await _courseInfoRepository.GetCourseAsync(courseId, false);
            _courseInfoRepository.DeleteCourse(courseToDelete!);
            await _courseInfoRepository.SaveChangeAsync();
            return NoContent();
        }

        
    }
}
