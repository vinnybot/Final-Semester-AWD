namespace Linq.Models
{
    public class BookDTO
    {
        public string BookCode { get; set; } = null!;

        public string? Title { get; set; }

        public decimal? Price { get; set; }

        public decimal? DiscountedPrice { get; set; } => Price * .9M;


    }
}
