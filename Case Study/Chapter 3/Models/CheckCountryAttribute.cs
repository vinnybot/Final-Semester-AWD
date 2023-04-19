using System.ComponentModel.DataAnnotations;
namespace Chapter_3.Models
{
    public class CheckCountryAttribute : ValidationAttribute
    {
        private object compareValue;

        public CheckCountryAttribute(object value)
        {
            compareValue = value;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext ctx)
        {
            if (value is string)
            {
                string stringToCheck = (string)value;
                string stringToCompare = (string)compareValue;

                if (int.Parse(stringToCheck) > int.Parse(stringToCompare))
                {
                    return ValidationResult.Success!;
                }
            }
            string msg = base.ErrorMessage ?? $"Please select a country";
            return new ValidationResult(msg);
        }
    }
}
