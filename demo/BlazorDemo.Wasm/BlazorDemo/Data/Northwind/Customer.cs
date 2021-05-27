using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Northwind {
    [Guid("376AA7C3-5EEE-40B6-BD1A-8F38F6E2BEA7")]
    public partial class Customer {
        public Customer() {
            Orders = new HashSet<Order>();
        }

        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
