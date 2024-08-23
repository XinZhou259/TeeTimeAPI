using System.ComponentModel.DataAnnotations;

namespace TeeTimeAPI.Models
{
    public class CourseForUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public String CourseName { get; set; } = string.Empty;
        [Required]
        [MaxLength(200)]
        public String CourseUrl { get; set; } = String.Empty;
    }
}
