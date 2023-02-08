using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data.Northwind;
public class EditorsEmployee {
    public int EmployeeId { get; set; }
    public string LastName { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string Title { get; set; }
    public string TitleOfCourtesy { get; set; }
    public Nullable<System.DateTime> BirthDate { get; set; }
    [Required]
    [Range(typeof(DateTime), "1/1/2000", "1/1/2022", ErrorMessage = "HireDate must be between {1:d} and {2:d}")]
    public Nullable<System.DateTime> HireDate { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string HomePhone { get; set; }
    public string Extension { get; set; }
    public byte[] Photo { get; set; }
    [StringLength(maximumLength: 256, ErrorMessage = "The Notes value exceeds 256 characters.")]
    public string Notes { get; set; }
    public Nullable<int> ReportsTo { get; set; }
    public string PhotoPath { get; set; }

    public static explicit operator Employee(EditorsEmployee editorsEmployee) {
        return new Employee {
            FirstName = editorsEmployee.FirstName,
            HireDate = editorsEmployee.HireDate,
            City = editorsEmployee.City,
            Title = editorsEmployee.Title
        };
    }
}
