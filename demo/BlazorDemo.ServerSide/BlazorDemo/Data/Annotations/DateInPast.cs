using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data.Annotations {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class DateInPastAttribute : ValidationAttribute {
        public int YearsAgo { get; set; } = 0;

        public override bool IsValid(object value) {
            return (DateTime)value <= DateTime.Now.AddYears(-YearsAgo);
        }
    }
}
