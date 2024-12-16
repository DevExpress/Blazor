using BlazorDemo.DataProviders;
using System.Collections.Generic;

namespace BlazorDemo.Data.Sales {
    public class SalesPersonEntity {
        string _name;
        public SalesPersonEntity(string name) {
            Name = name;
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public List<OrderEntity> Orders { get; } = new List<OrderEntity>();
    }
}
