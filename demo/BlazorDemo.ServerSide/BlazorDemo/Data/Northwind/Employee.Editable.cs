using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Northwind {
    [Guid("EF601232-5963-43D7-BDCF-FEC4096110C2")]
    public partial class EditableEmployee {
        public int EmployeeId { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        [Required]
        [Range(typeof(DateTime), "1/1/1970", "1/1/2000", ErrorMessage = "BirthDate must be between {1:d} and {2:d}")]
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
        [StringLength(maximumLength: 512, ErrorMessage = "The Notes value exceeds 512 characters.")]
        public string Notes { get; set; }
        public Nullable<int> ReportsTo { get; set; }
        public string PhotoPath { get; set; }
    }
}
