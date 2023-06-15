using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Homes {
    [Guid("579150BE-0ADA-4DA6-9557-534CCE36B69C")]
    public partial class Order {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? ProductId { get; set; }
        public byte[] PurchaseDate { get; set; }
        public byte[] Time { get; set; }
        public string PaymentType { get; set; }
        public byte[] PaymentAmount { get; set; }
        public string Description { get; set; }
        public long? Quantity { get; set; }
    }
}
