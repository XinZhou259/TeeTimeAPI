namespace TeeTimeAPI.Models
{
    public class TeeTimeDto
    {
        public int Id { get; set; }        
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPlayer { get; set; }
        public double Price { get; set; }
    }
}
