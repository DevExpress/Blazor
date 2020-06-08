using System;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    [Guid("3B39878B-4108-4303-B76F-42C989CDB9EE")]
    public partial class AreaRentInfo {
        public AreaRentInfo() {
        }

        public Guid Oid { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Year { get; set; }
        public int Bedrooms { get; set; }
        public decimal Rent { get; set; }
    }
}
