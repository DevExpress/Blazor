using System;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    [Guid("F1D941D9-D9D4-4BB6-B1B9-EF2AE5C95D6B")]
    public class ProductFlat {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public bool Availability { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory CategoryItem { get; set; }
        public string Category => CategoryItem?.Category.ToString();
        public string Subcategory => CategoryItem?.Subcategory;

        public DateTime LastUpdated => CategoryItem != null ? CategoryItem.LastUpdated : DateTime.Now;
        public string TextField => $"Id{Id}: {ProductName} ({ (Availability ? "In stock" : "Sold out") })";
    }
}
