using System.ComponentModel.DataAnnotations;

namespace TeeTimeAPI.Models
{
    public class CourseForCreateDto
    {
        [Required(ErrorMessage = "Please provide a course name.")]
        [MaxLength(50)]
        public String? CourseName { get; set; }

        [Required(ErrorMessage = "Please provide a course URL.")]
        [MaxLength(200)]
        public String? CourseUrl { get; set; }
    }
}
