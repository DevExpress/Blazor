using System;
using System.Collections.Generic;

namespace Demo.RazorComponents.Model
{
    public partial class Sale
    {
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
