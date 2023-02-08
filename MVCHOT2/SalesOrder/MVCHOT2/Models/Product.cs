using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MVCHOT2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a short description for this product.")]
        public string ShortDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a long description for this product.")]

        public string LongDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide an image for this product.")]
        public string Image = string.Empty;

        [Required(ErrorMessage = "Please enter a price between 1 - 100000")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Please enter a quantity between 1- 1000")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Price?.ToString();
    }
}
