using System;
using System.Collections.Generic;
using System.Diagnostics;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders.Implementation;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Homes {
    [Guid("1F31A5DD-E2A7-47E7-A420-A4D3BE9252B4")]
    public partial class Home {
        public long Id { get; set; }
        public string Address { get; set; }
        public long? Beds { get; set; }
        public long? Baths { get; set; }
        public double? HouseSize { get; set; }
        public double? LotSize { get; set; }
        public double? Price { get; set; }
        public string Features { get; set; }
        public string YearBuilt { get; set; }
        public long? Type { get; set; }
        public long? Status { get; set; }
        public string RtfContent { get; set; }
        public string PhotoUrl => $"homes/{Id}.jpg";
    }
}

