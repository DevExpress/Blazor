using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services
{
    public class ProductService
    {
        readonly IProductsProvider _productsProvider;
        readonly IProductCategoriesProvider _productCategoriesProvider;
        public ProductService(IProductsProvider productsProvider, IProductCategoriesProvider productCategoriesProvider)
        {
            _productsProvider = productsProvider;
            _productCategoriesProvider = productCategoriesProvider;
        }
        public Task<IEnumerable<Product>> LoadAsync(CancellationToken ct = default) {
            return _productsProvider.LoadAsync(ct);
        }
        public Task<IEnumerable<ProductCategory>> LoadNestedDataSource(CancellationToken ct = default)
        {
            return _productCategoriesProvider.GetProductCategoriesAsync(ct);
        }
        public Task RemoveAsync(Product dataItem)
        {
            return _productsProvider.RemoveAsync(dataItem);
        }
        public Task UpdateAsync(Product product, IDictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "Id":
                        product.Id = (string)newValue[field];
                        break;
                    case "ProductName":
                        product.ProductName = (string)newValue[field];
                        break;
                    case "Availability":
                        product.Availability  = Convert.ToBoolean(newValue[field]);
                        break;
                    case "ProductCategoryId":
                        product.ProductCategoryId = (int)newValue[field];
                        break;
                }
            }
            return Task.CompletedTask;
        }
        public Task InsertAsync(IDictionary<string, object> newValue)
        {
            if(!newValue.ContainsKey(nameof(Product.Id)))
                newValue.Add(nameof(Product.Id), Guid.NewGuid().ToString());

            var dataItem = new Product();
            UpdateAsync(dataItem, newValue);
            return _productsProvider.AddAsync(dataItem);
        }
    }
}
