using System;
namespace Demo.Blazor.Services {

    public class WebApiOrder {
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Freight { get; set; }
        public string ShipCountry { get; set; }
        public int ShipVia { get; set; }
    }

    public class WebApiCustomerLookup {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class WebApiShipperLookup {
        public string Text { get; set; }
        public int Value { get; set; }
    }
}
