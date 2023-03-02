using System.ComponentModel.DataAnnotations;

namespace Chapter_8.Models
{
    public class Trip
    {
        public int TripID { get; set; }

        [Required(ErrorMessage = "Please enter a Destination")]
        public string Destination { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Start Date")]
        public DateTime? StartDate { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an End Date")]
        public DateTime? EndDate { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an Accommodation")]
        public string? Accommodation { get; set; } = string.Empty;

        public string? AccommodationPhone { get; set; } = string.Empty;

        public string? AccommodationEmail { get; set; } = string.Empty;

        public string? Activity1 { get; set; } = null;
        public string? Activity2 { get; set; } = null;
        public string? Activity3 { get; set; } = null;
    }
}
