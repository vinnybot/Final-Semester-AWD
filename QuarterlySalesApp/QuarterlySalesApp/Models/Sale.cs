using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using QuarterlySalesApp.Models.Validation;
using Microsoft.AspNetCore.Mvc;

namespace QuarterlySalesApp.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        [Required(ErrorMessage = "Please enter a quarter")]
        [Range(1,4, ErrorMessage = "Quarter must be between 1 and 4")]
        public int? Quarter { get; set; } // four quarters in a year

        [Required(ErrorMessage = "Year is required.")]
        [GreaterThan(2000, ErrorMessage = "Year may not be before 2001.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [GreaterThan(0.0, ErrorMessage = "Amount must be greater than 0.")]
        public double? Amount { get; set; }

        // FK property
        [GreaterThan(0, ErrorMessage = "Please select an employee.")]
        [Display(Name = "Employee")]
        [Remote("CheckSales", "Validation", AdditionalFields = "Quarter, Year")]
        public int EmployeeId { get; set; }

        [ValidateNever]
        public Employee Employee { get; set; } = null!; // related entity property.



    }
}
