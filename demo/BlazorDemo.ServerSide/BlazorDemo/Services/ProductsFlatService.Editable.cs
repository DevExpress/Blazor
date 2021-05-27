using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class ProductsFlatService {
        public Task UpdateAsync(ProductFlat item, IDictionary<string, object> newValue) {
            // Change your data here
            /*BeginHide*/
            UpdateItem(item, newValue);
            return Task.CompletedTask;
            /*EndHide*/
        }
        public Task AddAsync(IDictionary<string, object> newValue) {
            // Change your data here
            /*BeginHide*/
            var item = new ProductFlat();
            UpdateItem(item, newValue);
            return _provider.Add(item);
            /*EndHide*/
        }
        public Task RemoveAsync(ProductFlat item) {
            // Change your data here
            /*BeginHide*/
            return _provider.Remove(item);
            /*EndHide*/
        }
        /*BeginHide*/
        static void UpdateItem(ProductFlat item, IDictionary<string, object> newValue) {
            foreach(var field in newValue)
                UpdateItem(item, field.Key, field.Value);
        }
        static void UpdateItem(ProductFlat item, string name, object value) {
            switch(name) {
                case "Id":
                    item.Id = (string)value; return;
                case "ProductName":
                    item.ProductName = (string)value; return;
                case "Availability":
                    item.Availability = (bool)value; return;
                case "ProductCategoryId":
                    item.ProductCategoryId = (int)value; return;
                case "Category":
                    if(item.CategoryItem == null) item.CategoryItem = new ProductCategory();
                    item.CategoryItem.Category = value is ProductCategoryMain ? (ProductCategoryMain)value : Enum.Parse<ProductCategoryMain>((string)value);
                    return;
                case "Subcategory":
                    if(item.CategoryItem == null) item.CategoryItem = new ProductCategory();
                    item.CategoryItem.Subcategory = (string)value; return;
            }
        }
        /*EndHide*/
    }
}
