using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Blazor.Model
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public bool Availability  { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
