﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.IdentityModel.Tokens;

namespace RegistrationApp.Models
{
    public class MinimumAgeAttribute : ValidationAttribute, IClientModelValidator
    {
        private int minYears;
        public MinimumAgeAttribute(int years)
        {
            minYears = years;
        }

        //overrides IsValid() method of ValidationAttribute base class
        protected override ValidationResult IsValid(object? value, ValidationContext ctx)
        {
            if (value is DateTime)
            {
                DateTime dateToCheck = (DateTime)value;
                dateToCheck = dateToCheck.AddYears(minYears);
                if (dateToCheck <= DateTime.Today)
                {
                    return ValidationResult.Success!;
                }
            }
            return new ValidationResult(GetMsg(ctx.DisplayName ?? "Date"));
        }

        public void AddValidation(ClientModelValidationContext ctx)
            {
                if (!ctx.Attributes.ContainsKey("data-val"))
                    ctx.Attributes.Add("data-val", "true");
                ctx.Attributes.Add("data-val-minimumage-years",
                    minYears.ToString());
                ctx.Attributes.Add("data-val-minimumage",
                    GetMsg(ctx.ModelMetadata.DisplayName ?? ctx.ModelMetadata.Name ?? "Date"));
            }

        public string GetMsg(string name)  =>
            base.ErrorMessage ?? $"{name} must be at least {minYears} years ago";
    }
}
