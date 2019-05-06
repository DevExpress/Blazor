using System;
using System.Collections.Generic;

namespace Demo.Blazor.Model
{
    public partial class AreaRentInfo
    {
        public AreaRentInfo()
        {
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
