using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TeeTimeAPI.Models;
using TeeTimeAPI.Services;

namespace TeeTimeAPI.Controllers
{
    [Route("/v{version:apiVersion}/courses/{courseId}")]
    [ApiController]
    [ApiVersion(1)]
    [ApiVersion(2)]
    public class TeeTimesController : ControllerBase
    {
        private readonly ICourseInfoRepository _courseInfoRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TeeTimesController> _logger;
        const int maxTeeTimePageSize = 20;

        public TeeTimesController(ICourseInfoRepository courseInfoRepository,
            IMapper mapper, ILogger<TeeTimesController> logger)
        {
            _courseInfoRepository = courseInfoRepository ?? throw new ArgumentNullException(nameof(courseInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("teetimes")]
        public async Task<ActionResult<IEnumerable<TeeTimeDto>>> GetTeeTimes(int courseId,
            [FromQuery(Name = "date")] DateTime? date, [FromQuery] int currentPage = 1, [FromQuery] int pageSize = 3)
        {
            if (pageSize > maxTeeTimePageSize)
            {
                pageSize = maxTeeTimePageSize;
            }

            if (!await _courseInfoRepository.CourseExistsAsync(courseId))
            {
                _logger.LogInformation($"Course with id {courseId} wasn't found");
                return NotFound();
            }

            var (teeTimesOfCourse, paginationMetadata) = await _courseInfoRepository.GetTeeTimesAsync(courseId, date, currentPage, pageSize);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<TeeTimeDto>>(teeTimesOfCourse));


        }

        [HttpGet("teetimes/{teeTimeId}", Name = "GetTeeTime")]
        public async Task<ActionResult<TeeTimeDto>> GetTeeTime(int courseId, int teeTimeId)
        {
            if (!await _courseInfoRepository.CourseExistsAsync(courseId))
            {
                _logger.LogInformation($"Course with id {courseId} wasn't found");
                return NotFound();
            }

            var teeTime = await _courseInfoRepository.GetTeeTimeAsync(courseId, teeTimeId);


            if (teeTime == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TeeTimeDto>(teeTime));
        }

        [HttpPost]
        public async Task<ActionResult<TeeTimeDto>> AddTeeTimeToCourse(int courseId, TeeTimeForCreateDto TeeTime)
        {


            if (!await _courseInfoRepository.CourseExistsAsync(courseId))
            {
                _logger.LogInformation($"Course with id {courseId} wasn't found");
                return NotFound();
            }

            var teeTimeToAdd = _mapper.Map<Entities.TeeTime>(TeeTime);

            await _courseInfoRepository.AddTeeTimeToCourseAsync(courseId, teeTimeToAdd);
            await _courseInfoRepository.SaveChangeAsync();

            var addedTeeTime = _mapper.Map<TeeTimeDto>(teeTimeToAdd);

            return CreatedAtRoute("GetTeeTime",
                new
                {
                    courseId = courseId,
                    teeTimeId = addedTeeTime.Id
                },
                addedTeeTime);

        }

        [HttpPost("teetimes")]
        public async Task<ActionResult> AddTeeTimesToCourse(int courseId, IEnumerable<TeeTimeForCreateDto> TeeTimes)
        {


            if (!await _courseInfoRepository.CourseExistsAsync(courseId))
            {
                _logger.LogInformation($"Course with id {courseId} wasn't found");
                return NotFound();
            }

            var teeTimesToAdd = _mapper.Map<IEnumerable<Entities.TeeTime>>(TeeTimes);

            await _courseInfoRepository.AddTeeTimesToCourseAsync(courseId, teeTimesToAdd);

            await _courseInfoRepository.SaveChangeAsync();

            return NoContent();
        }
    }
}
