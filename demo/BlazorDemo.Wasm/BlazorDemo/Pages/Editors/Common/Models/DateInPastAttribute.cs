using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Pages.Editors.Common.Models;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class DateInPastAttribute : ValidationAttribute {
    public override bool IsValid(object value) {
        return (DateTime)value <= DateTime.Today;
    }
}
