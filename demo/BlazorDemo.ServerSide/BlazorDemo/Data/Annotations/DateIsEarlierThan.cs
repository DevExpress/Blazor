using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data.Annotations {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
    public class DateIsEarlierThanAttribute : ValidationAttribute {
        readonly string datePropertyToCompare;
        public DateIsEarlierThanAttribute(string datePropertyToCompare) {
            this.datePropertyToCompare = datePropertyToCompare;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            var property = validationContext.ObjectType.GetProperty(datePropertyToCompare);
            if(property == null) {
                return new ValidationResult(
                    $"Unknown property: {datePropertyToCompare}",
                    new[] { validationContext.MemberName });
            }

            if((DateTime)value > (DateTime)property.GetValue(validationContext.ObjectInstance)) {
                return new ValidationResult(
                    ErrorMessage ?? $"The {validationContext.MemberName} value cannot be greater than the {datePropertyToCompare} value",
                    new[] { validationContext.MemberName, datePropertyToCompare });
            }
            return ValidationResult.Success;
        }
    }
}
