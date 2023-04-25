using System.ComponentModel.DataAnnotations;

namespace MVCHOT2.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(255)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(255)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your email address.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
