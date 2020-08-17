using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    class FlatProductService {
        private readonly IFlatProductsProvider _provider;

        public FlatProductService(IFlatProductsProvider provider) {
            _provider = provider;
        }

        public Task<IEnumerable<ProductFlat>> LoadProductsAsync(CancellationToken ct) {
            return _provider.LoadAsync(ct);
        }
        public Task Update(ProductFlat item, IDictionary<string, object> newValue) {
            UpdateItem(item, newValue);
            return Task.CompletedTask;
        }
        public Task Add(IDictionary<string, object> newValue) {
            var item = new ProductFlat();
            UpdateItem(item, newValue);
            return _provider.Add(item);
        }
        public Task Remove(ProductFlat item) {
            return _provider.Remove(item);
        }
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
    }
}
