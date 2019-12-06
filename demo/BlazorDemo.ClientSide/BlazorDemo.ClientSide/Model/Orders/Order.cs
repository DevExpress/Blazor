using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public class Order {
        public int OrderID { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipRegionID { get; set; }
        public int UnitsInOrder { get; set; }
    }
}
