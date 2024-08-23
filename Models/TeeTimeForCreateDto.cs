namespace TeeTimeAPI.Models
{
    public class TeeTimeForCreateDto
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public int NumberOfPlayer { get; set; }
        public double Price { get; set; }
    }
}
