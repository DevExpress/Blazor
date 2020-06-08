using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    class ProductCategoriesProvider : DataProviderBase, IProductCategoriesProvider {
        public Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync(CancellationToken ct = default) {
            return Task.FromResult(_dataSource.Value);
        }
        internal static readonly Lazy<IEnumerable<ProductCategory>> _dataSource = new Lazy<IEnumerable<ProductCategory>>(() => {
            return new [] {
                new ProductCategory() { SubcategoryID = 1 ,   Category = ProductCategoryMain.Bikes      ,    Subcategory = "Mountain Bikes",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 2 ,   Category = ProductCategoryMain.Bikes      ,    Subcategory = "Road Bikes",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 3 ,   Category = ProductCategoryMain.Bikes      ,    Subcategory = "Touring Bikes",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 4 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Handlebars",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 5 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Bottom Brackets",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 6 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Brakes",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 7 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Chains",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 8 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Cranksets",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 9 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Derailleurs",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 10,   Category = ProductCategoryMain.Components ,    Subcategory = "Forks",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 11,   Category = ProductCategoryMain.Components ,    Subcategory = "Headsets",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 12,   Category = ProductCategoryMain.Components ,    Subcategory = "Mountain Frames",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 13,   Category = ProductCategoryMain.Components ,    Subcategory = "Pedals",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 14,   Category = ProductCategoryMain.Components ,    Subcategory = "Road Frames",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 15,   Category = ProductCategoryMain.Components ,    Subcategory = "Saddles",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 16,   Category = ProductCategoryMain.Components ,    Subcategory = "Touring Frames",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 17,   Category = ProductCategoryMain.Components ,    Subcategory = "Wheels",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 18,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Bib-Shorts",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 19,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Caps",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 20,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Gloves",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 21,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Jerseys",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 22,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Shorts",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 23,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Socks",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 24,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Tights",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 25,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Vests",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 26,   Category = ProductCategoryMain.Accessories,    Subcategory = "Bike Racks",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 27,   Category = ProductCategoryMain.Accessories,    Subcategory = "Bike Stands",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 28,   Category = ProductCategoryMain.Accessories,    Subcategory = "Bottles and Cages",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 29,   Category = ProductCategoryMain.Accessories,    Subcategory = "Cleaners",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 30,   Category = ProductCategoryMain.Accessories,    Subcategory = "Fenders",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 31,   Category = ProductCategoryMain.Accessories,    Subcategory = "Helmets",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 32,   Category = ProductCategoryMain.Accessories,    Subcategory = "Hydration Packs",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 33,   Category = ProductCategoryMain.Accessories,    Subcategory = "Lights",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 34,   Category = ProductCategoryMain.Accessories,    Subcategory = "Locks",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 35,   Category = ProductCategoryMain.Accessories,    Subcategory = "Panniers",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 36,   Category = ProductCategoryMain.Accessories,    Subcategory = "Pumps",  LastUpdated = DateTime.Parse("2019-06-01") },
                new ProductCategory() { SubcategoryID = 37,   Category = ProductCategoryMain.Accessories,    Subcategory = "Tires and Tubes",  LastUpdated = DateTime.Parse("2019-06-01") },
            };
        });
    }
}