using System;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    [Guid("8791CE9F-7F60-48F4-9F90-E180EC97DA95")]
    public class Sale {
        public int Id { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductSubcategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? SalesQuantity { get; set; }
        public decimal? SalesAmount { get; set; }
        public DateTime? DateKey { get; set; }
        public string StoreName { get; set; }
    }
}
