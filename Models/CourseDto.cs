namespace TeeTimeAPI.Models
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseURL { get; set; }
        public List<TeeTimesDto>? TeeTimes { get; set; }
    }
}
