using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Chapter_3.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter a customer name.")]

        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a city")]

        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an Address")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a postal code")]
        public int? PostalCode { get; set; }
        [Required(ErrorMessage = "Please enter a country")]
        public string CountryId { get; set; } = string.Empty;

        [ValidateNever]
        public Country Country { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
