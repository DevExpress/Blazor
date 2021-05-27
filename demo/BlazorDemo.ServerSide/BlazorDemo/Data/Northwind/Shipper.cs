using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Northwind {
    [Guid("6FCC2F07-4572-413B-98DC-A57E7F5EA37F")]
    public partial class Shipper {
        public Shipper() {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
