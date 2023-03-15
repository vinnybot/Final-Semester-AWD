using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MVCHOT2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a short description for this product.")]
        public string ProductDescShort { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a long description for this product.")]

        public string ProductDescLong { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide an image for this product.")]
        public string ProductImage = string.Empty;

        [Required(ErrorMessage = "Please enter a price between 1 - 100000")]
        public decimal? ProductPrice { get; set; }

        [Required(ErrorMessage = "Please enter a quantity between 1- 1000")]
        public int? ProductQty { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public int CategoryID { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        public string Slug => ProductName?.Replace(' ', '-').ToLower() + '-' + ProductPrice?.ToString();
    }
}
