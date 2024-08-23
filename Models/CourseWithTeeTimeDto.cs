namespace TeeTimeAPI.Models
{
    public class CourseWithTeeTimeDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseURL { get; set; } = string.Empty;
        public List<TeeTimeDto>? TeeTimes { get; set; }
    }
}
