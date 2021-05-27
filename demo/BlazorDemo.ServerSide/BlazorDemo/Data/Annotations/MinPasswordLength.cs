using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data.Annotations {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class MinPasswordLengthAttribute : ValidationAttribute {
        int MinLength { get; }
        public MinPasswordLengthAttribute(int minLength, string errorMsg) : base(errorMsg) {
            MinLength = minLength;
        }

        public override bool IsValid(object value) {
            return ((string)value).Length >= MinLength;
        }
    }
}
