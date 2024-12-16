using BlazorDemo.DataProviders;
using System.Collections.Generic;

namespace BlazorDemo.Data.Sales {
    public class CategoryEntity {
        string _name;
        public CategoryEntity(string name) {
            Name = name;
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public List<ProductEntity> Products { get; } = new List<ProductEntity>();
    }
}
