using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Demo.Blazor.Model {
    public class ProductFlat {
        static object locker = new object();
        static List<ProductCategory> CategoryDataSource = new List<ProductCategory>(ProductCategories.DataSource);

        public string Id { get; set; }
        public string ProductName { get; set; }
        public bool Availability { get; set; }
        public int ProductCategoryId { get; set; }

        ProductCategory categoryItem;
        ProductCategory CategoryItem { 
            get { 
                if(categoryItem == null) {
                    lock(locker) { 
                        if(categoryItem == null) {
                            categoryItem = CategoryDataSource.Where(x => x.ProductSubcategoryID == ProductCategoryId).FirstOrDefault();
                        }
                    }
                }
                    
                return categoryItem;
            }
        }
        public string Category => CategoryItem.Category.ToString();
        public string Subcategory => CategoryItem?.Subcategory;
        public DateTime LastUpdatedDate => CategoryItem.LastUpdatedDate;
    }
}
