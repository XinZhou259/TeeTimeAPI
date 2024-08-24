using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeeTimeAPI.Entities
{
    public class TeeTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public DateTime Date { get; set; }       
        public TimeSpan Time { get; set; }
        public int NumberOfPlayer { get; set; }
        public double Price { get; set; }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
        public int CourseId { get; set; }
        public TeeTime(DateTime date, TimeSpan time, int numberOfPlayer, double price)
        {
            Date = date;
            Time = time;
            NumberOfPlayer = numberOfPlayer;
            Price = price;
        }

        
    }

}
