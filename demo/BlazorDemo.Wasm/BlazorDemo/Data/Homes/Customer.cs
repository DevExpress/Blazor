using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Homes {
    [Guid("E2E0A7A8-116F-4E6F-9CF1-61E050F81EB0")]
    public partial class Customer {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Prefix { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Source { get; set; }
        public string Customer1 { get; set; }
        public string HomePhone { get; set; }
        public string FaxPhone { get; set; }
        public string Spouse { get; set; }
        public string Occupation { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}
