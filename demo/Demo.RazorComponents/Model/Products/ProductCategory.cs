using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.RazorComponents.Model
{
    public enum ProductCategoryMain { Bikes, Components, Clothing, Accessories }
    public class ProductCategory
    {
        public int ProductSubcategoryID { get; set; }
        public ProductCategoryMain Category { get; set; }
        public string Subcategory { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
