using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Northwind {
    [Guid("EF601232-5963-43D7-BDCF-FEC4096110C1")]
    public partial class Employee {
        public Employee() {
            this.Orders = new List<Order>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public string Text => $"{FirstName} {LastName} ({Title})";
        public string FullName => $"{FirstName} {LastName}";
        public string ImageFileName => $"employees/{EmployeeId}.jpg";
    }
}
