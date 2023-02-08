using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace Chapter_3.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a product name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a product code.")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a price.")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Please enter release date. ")]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
