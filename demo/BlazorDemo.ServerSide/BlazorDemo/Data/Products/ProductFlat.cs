using System;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    public class ProductFlat {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public bool Availability { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory CategoryItem { get; set; }
        public string Category => CategoryItem?.Category.ToString();
        public string Subcategory => CategoryItem?.Subcategory;
    }
}
