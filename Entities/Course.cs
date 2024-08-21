using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeeTimeAPI.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(200)]
        public string CourseURL { get; set; }

        public ICollection<TeeTime>? TeeTimes { get; set; } = new List<TeeTime>();

        public Course(string courseName, string courseURL)
        {
            CourseName = courseName;
            CourseURL = courseURL;
        }
    }
}


