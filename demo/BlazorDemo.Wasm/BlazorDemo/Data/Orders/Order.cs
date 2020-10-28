using System;

namespace BlazorDemo.Data {
    public class Order {
        public int OrderID { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int CountryId { get; set; }
        public int UnitsInOrder { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
    public enum OrderStatus {
        Processing,
        InTransit,
        Delivered
    }
}
