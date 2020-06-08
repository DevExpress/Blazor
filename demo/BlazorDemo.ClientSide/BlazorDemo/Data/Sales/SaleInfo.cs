using System;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    [Guid("AAD50025-F338-4833-A10E-0C8260E0AF65")]
    public class SaleInfo {
        public int OrderId { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
