namespace Chapter_8.Models
{
    public class TripViewModel
    {
        public int PageNumber { get; set; }
        public Trip Trip { get; set; } = new Trip();
    }
}
