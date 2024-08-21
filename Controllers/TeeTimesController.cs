using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeeTimeAPI.Models;
using TeeTimeAPI.Services;

namespace TeeTimeAPI.Controllers
{
    [Route("/courses/{courseId}/teetimes")]
    [ApiController]
    public class TeeTimesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly ILogger<TeeTimesController> _logger;

        public TeeTimesController(ICourseService courseService, ILogger<TeeTimesController> logger)
        {
            _courseService = courseService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TeeTimesDto>> GetTeeTimes(int courseId)
        {
            //throw new Exception("This is a test exception");
            try
            {
                
                var course = _courseService.GetCourse(courseId);
                if (course == null)
                {
                    _logger.LogInformation($"Course with id {courseId} was not found");
                    return NotFound();
                }
                return Ok(course.TeeTimes);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "An error occurred while getting the tee times");
                
                return StatusCode(500, "A problem happended while handling your request.");


            }
        }

        [HttpGet("{teetimeid}")]
        public ActionResult<TeeTimesDto> GetTeeTime(int courseId, int teetimeid){
            var course = _courseService.GetCourse(courseId);
            if (course == null)
                {return NotFound();}
            var teeTime = course.TeeTimes.FirstOrDefault(t => t.Id == teetimeid);
            if (teeTime == null)
                {return NotFound();}
            return Ok(teeTime);
        }
    }
}
