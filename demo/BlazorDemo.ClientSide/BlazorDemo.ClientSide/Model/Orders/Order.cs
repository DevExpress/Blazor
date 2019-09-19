using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public class Order {
        public int OrderID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public int ShipRegionID { get; set; }
    }
}
