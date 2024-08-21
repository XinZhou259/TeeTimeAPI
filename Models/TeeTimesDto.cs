namespace TeeTimeAPI.Models
{
    public class TeeTimesDto
    {
        public int Id { get; set; }        
        public string Date { get; set; }
        public string Time { get; set; }     
        public string NumberOfPlayer { get; set; }
        public int Price { get; set; }
    }
}
