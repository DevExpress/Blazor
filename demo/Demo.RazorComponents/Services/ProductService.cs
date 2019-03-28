using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.RazorComponents.Model;

namespace Demo.RazorComponents.Services
{
    public class ProductService
    {
        IList<Product> dataSource;
        IList<ProductCategory> nestedDataSource;
        public ProductService()
        {
            nestedDataSource = ProductCategories.DataSource;
            dataSource = Products.Load();
        }
        public Task<IQueryable<Product>> Load()
        {
            return Task.FromResult(dataSource.AsQueryable());
        }
        public Task<IQueryable<ProductCategory>> LoadNestedDataSource()
        {
            return Task.FromResult(nestedDataSource.AsQueryable());
        }
        public void Remove(Product dataItem)
        {
            ((IList<Product>)dataSource).Remove(dataItem);
        }
        public void Update(Product product, Dictionary<string, object> newValue)
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
        }
        public void Insert(Dictionary<string, object> newValue)
        {
            var dataItem = new Product();
            Update(dataItem, newValue);
            ((IList<Product>)dataSource).Add(dataItem);
        }
    }
}
