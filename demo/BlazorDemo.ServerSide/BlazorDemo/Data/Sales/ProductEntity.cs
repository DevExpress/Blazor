using BlazorDemo.DataProviders;
using System.Collections.Generic;

namespace BlazorDemo.Data.Sales {
    public class ProductEntity {
        string _name;
        CategoryEntity _category;
        decimal _price;
        public ProductEntity(string name, CategoryEntity category, decimal price) {
            Name = name;
            Category = category;
            Category.Products.Add(this);
            Price = price;
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public CategoryEntity Category {
            get { return _category; }
            set { _category = value; }
        }
        public List<SaleEntity> Sales { get; } = new List<SaleEntity>();
        public decimal Price {
            get { return _price; }
            set { _price = value; }
        }
    }
}
