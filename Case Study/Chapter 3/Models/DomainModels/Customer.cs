using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Chapter_3.Models.DomainModels
{
    public class Customer
    {
        public Customer() => Products = new HashSet<Product>();
        public int CustomerId { get; set; }

        [StringLength(50, ErrorMessage = "Name must be between 1 - 50 characters.", MinimumLength = 1)]
        [Required(ErrorMessage = "Please enter a customer name.")]
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Email must be between 1 - 50 characters.", MinimumLength = 1)]
        [Remote("CheckEmail", "Validation", AdditionalFields = nameof(CustomerId))]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a city")]
        [StringLength(50, ErrorMessage = "City must be between 1 - 50 characters.", MinimumLength = 1)]

        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an Address")]
        [StringLength(50, ErrorMessage = "Address must be between 1 - 50 characters.", MinimumLength = 1)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a state")]
        [StringLength(50, ErrorMessage = "Address must be between 1 - 50 characters.", MinimumLength = 1)]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a postal code")]
        [StringLength(20, ErrorMessage = "Postal Code must be between 1 - 20 characters.", MinimumLength = 1)]
        public string? PostalCode { get; set; }
        [Required(ErrorMessage = "Please enter a country")]

        public string CountryId { get; set; } = string.Empty;

        [ValidateNever]
        public Country Country { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a Phone Number")]
        [StringLength(20, ErrorMessage = "Phone number must be between 1 and 20 characters and have the (999) 999-9999 format.", MinimumLength = 1)]
        [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]\\d{3}[\\s.-]\\d{4}$")]
        public string PhoneNumber { get; set; } = string.Empty;

        //Skip-Nav Property
        public ICollection<Product> Products { get; set; }
    }
}
