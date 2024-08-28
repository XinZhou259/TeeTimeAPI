namespace TeeTimeAPI.Models
{
    /// <summary>
    /// A course without tee times
    /// </summary>
    public class CourseDto
    {
        
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseURL { get; set; } = string.Empty;
    }
}
