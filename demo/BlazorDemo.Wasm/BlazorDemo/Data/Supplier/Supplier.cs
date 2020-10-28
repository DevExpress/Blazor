using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Data {
    public class Supplier {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int SupplierCategoryID { get; set; }
        public int? DeliveryMethodID { get; set; }
        public string BankAccountBranch { get; set; }
        public string BankAccountNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebsiteURL { get; set; }
    }
}
