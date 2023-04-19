using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using QuarterlySalesApp.Models.Validation;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace QuarterlySalesApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter an employee first name.")]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an employee last name.")]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a valid date of birth.")]
        [PastDate(ErrorMessage = "Birth date must be a valid date that's in the past.")]
        [Remote("CheckEmployee", "Validation", AdditionalFields = "Name, LastName")]
        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Please enter a hire date")]
        [PastDate(ErrorMessage = "Birth date must be a valid date that's in the past.")]
        [GreaterThan("1/1/1995", ErrorMessage = "Hire date cannot be before company was formed in 1995.")]
        [Display(Name = "Hire Date")]
        public DateTime? DateOfHire { get; set; }

        [Display(Name = "Manager")]
        [Remote("CheckManager", "Validation", AdditionalFields ="Name, LastName, DOB")]
        [GreaterThan(0, ErrorMessage = "You smell like onions")]
        public int ManagerId { get; set; } // no extra table, will link up with EmployeeId

        public string FullName => $"{Name} {LastName}";
    }
}
