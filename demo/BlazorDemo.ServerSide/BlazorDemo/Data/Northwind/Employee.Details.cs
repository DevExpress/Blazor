using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data.Northwind;
public class EmployeeDetails {
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [Range(typeof(DateTime), "1/1/2000", "1/1/2022", ErrorMessage = "HireDate must be between {1:d} and {2:d}")]
    public DateTime? HireDate { get; set; }
    public string City { get; set; }

    public static explicit operator EmployeeDetails(Employee employee) {
        return new EmployeeDetails {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            HireDate = employee.HireDate,
            City = employee.City,
            Title = employee.Title
        };
    }

    public string Text => $"{FirstName} {LastName} ({Title})";
}
