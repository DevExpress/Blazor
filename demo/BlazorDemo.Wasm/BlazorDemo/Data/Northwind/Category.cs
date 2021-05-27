using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Northwind {
    [Guid("92A02959-4585-4706-A6D5-529CB236A40D")]
    public partial class Category {
        public Category() {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
