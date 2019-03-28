using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.RazorComponents.Model
{
    public class ProductCategories
    {
        private static readonly Lazy<List<ProductCategory>> dataSource = new Lazy<List<ProductCategory>>(() =>
        {
            var dataSource = new List<ProductCategory>() {
                new ProductCategory() { ProductSubcategoryID = 1 ,   Category = ProductCategoryMain.Bikes      ,    Subcategory = "Mountain Bikes	",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 2 ,   Category = ProductCategoryMain.Bikes      ,    Subcategory = "Road Bikes		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 3 ,   Category = ProductCategoryMain.Bikes      ,    Subcategory = "Touring Bikes	    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 4 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Handlebars		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 5 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Bottom Brackets	",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 6 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Brakes			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 7 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Chains			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 8 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Cranksets		    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 9 ,   Category = ProductCategoryMain.Components ,    Subcategory = "Derailleurs		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 10,   Category = ProductCategoryMain.Components ,    Subcategory = "Forks			    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 11,   Category = ProductCategoryMain.Components ,    Subcategory = "Headsets			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 12,   Category = ProductCategoryMain.Components ,    Subcategory = "Mountain Frames	",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 13,   Category = ProductCategoryMain.Components ,    Subcategory = "Pedals			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 14,   Category = ProductCategoryMain.Components ,    Subcategory = "Road Frames		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 15,   Category = ProductCategoryMain.Components ,    Subcategory = "Saddles			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 16,   Category = ProductCategoryMain.Components ,    Subcategory = "Touring Frames	",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 17,   Category = ProductCategoryMain.Components ,    Subcategory = "Wheels			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 18,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Bib-Shorts		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 19,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Caps				",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 20,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Gloves			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 21,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Jerseys			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 22,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Shorts			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 23,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Socks			    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 24,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Tights			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 25,   Category = ProductCategoryMain.Clothing   ,    Subcategory = "Vests		        ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 26,   Category = ProductCategoryMain.Accessories,    Subcategory = "Bike Racks		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 27,   Category = ProductCategoryMain.Accessories,    Subcategory = "Bike Stands		",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 28,   Category = ProductCategoryMain.Accessories,    Subcategory = "Bottles and Cages ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 29,   Category = ProductCategoryMain.Accessories,    Subcategory = "Cleaners		    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 30,   Category = ProductCategoryMain.Accessories,    Subcategory = "Fenders		    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 31,   Category = ProductCategoryMain.Accessories,    Subcategory = "Helmets		    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 32,   Category = ProductCategoryMain.Accessories,    Subcategory = "Hydration Packs   ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 33,   Category = ProductCategoryMain.Accessories,    Subcategory = "Lights			",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 34,   Category = ProductCategoryMain.Accessories,    Subcategory = "Locks			    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 35,   Category = ProductCategoryMain.Accessories,    Subcategory = "Panniers		    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 36,   Category = ProductCategoryMain.Accessories,    Subcategory = "Pumps			    ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
                new ProductCategory() { ProductSubcategoryID = 37,   Category = ProductCategoryMain.Accessories,    Subcategory = "Tires and Tubes   ",  LastUpdatedDate = DateTime.Parse("1998-06-01") },
            };
            return dataSource;
        });
        public static List<ProductCategory> DataSource { get { return dataSource.Value; } }
    }
}
