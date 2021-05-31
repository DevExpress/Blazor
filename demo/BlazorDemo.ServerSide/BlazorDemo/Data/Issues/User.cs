using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BlazorDemo.Data.Issues {
    [Guid("5A52072B-7393-4641-A439-E7B98B13C6E3")]
    public partial class User {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
