using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    [Guid("2133498E-06E3-471C-90DD-8983C185CEB9")]
    public class Product {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public bool Availability { get; set; }
        public int ProductCategoryId { get; set; }

        public string TextField => $"Id{Id}: {ProductName} ({ (Availability ? "In stock" : "Sold out") })";
    }
}
