using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public class SupplierService {
        public List<Supplier> Suppliers { get; set; }
        public List<SupplierCategory> SupplierCategories { get; set; }
        public List<DeliveryMethod> DeliveryMethods { get; set; }
        public SupplierService() {
            Suppliers = CreateSuppliers();
            SupplierCategories = CreateSupplierCategories();
            DeliveryMethods = CreateDeliveryMethods();
        }
        public async Task<IEnumerable<Supplier>> GetSuppliersAsync(CancellationToken ct = default) {
            await Task.Delay(1000);//For demonstration purposes, emulate that data is get from an external storage with a delay.
            return Suppliers;
        }
        public async Task<IEnumerable<SupplierCategory>> GetSupplierCategoriesAsync(CancellationToken ct = default) {
            await Task.Delay(1000);//For demonstration purposes, emulate that data is get from an external storage with a delay.
            return SupplierCategories;
        }
        public async Task<IEnumerable<DeliveryMethod>> GetDeliveryMethodsAsync(CancellationToken ct = default) {
            await Task.Delay(1000);//For demonstration purposes, emulate that data is get from an external storage with a delay.
            return DeliveryMethods;
        }
        public Task<Supplier> GetSupplierByIdAsync(int id, CancellationToken ct = default) {
            return Task.FromResult(Suppliers.Where(m => m.SupplierID == id).FirstOrDefault());
        }
        private static List<Supplier> CreateSuppliers() {
            List<Supplier> Suppliers = new List<Supplier>();
            Suppliers.Add(new Supplier() { SupplierID = 1, SupplierName = "A Datum Corporation", SupplierCategoryID = 2, DeliveryMethodID = 7, BankAccountBranch = "Woodgrove Bank Zionsville", BankAccountNumber = "8575824136", PhoneNumber = "(847) 555-0100", FaxNumber = "(847) 555-0101", WebsiteURL = "http://www.adatum.com" });
            Suppliers.Add(new Supplier() { SupplierID = 2, SupplierName = "Contoso, Ltd.", SupplierCategoryID = 2, DeliveryMethodID = 9, BankAccountBranch = "Woodgrove Bank Greenbank", BankAccountNumber = "4587965215", PhoneNumber = "(360) 555-0100", FaxNumber = "(360) 555-0101", WebsiteURL = "http://www.contoso.com" });
            Suppliers.Add(new Supplier() { SupplierID = 3, SupplierName = "Consolidated Messenger", SupplierCategoryID = 6, BankAccountBranch = "Woodgrove Bank San Francisco", BankAccountNumber = "3254872158", PhoneNumber = "(415) 555-0100", FaxNumber = "(415) 555-0101", WebsiteURL = "http://www.consolidatedmessenger.com" });
            Suppliers.Add(new Supplier() { SupplierID = 4, SupplierName = "Fabrikam, Inc.", SupplierCategoryID = 4, DeliveryMethodID = 7, BankAccountBranch = "Woodgrove Bank Lakeview Heights", BankAccountNumber = "4125863879", PhoneNumber = "(203) 555-0104", FaxNumber = "(203) 555-0108", WebsiteURL = "http://www.fabrikam.com" });
            Suppliers.Add(new Supplier() { SupplierID = 5, SupplierName = "Graphic Design Institute", SupplierCategoryID = 2, DeliveryMethodID = 10, BankAccountBranch = "Woodgrove Bank Lanagan", BankAccountNumber = "1025869354", PhoneNumber = "(406) 555-0105", FaxNumber = "(406) 555-0106", WebsiteURL = "http://www.graphicdesigninstitute.com" });
            Suppliers.Add(new Supplier() { SupplierID = 6, SupplierName = "Humongous Insurance", SupplierCategoryID = 9, BankAccountBranch = "Woodgrove Bank Lancing", BankAccountNumber = "2569874521", PhoneNumber = "(423) 555-0105", FaxNumber = "(423) 555-0100", WebsiteURL = "http://www.humongousinsurance.com" });
            Suppliers.Add(new Supplier() { SupplierID = 7, SupplierName = "Litware, Inc.", SupplierCategoryID = 5, DeliveryMethodID = 2, BankAccountBranch = "Woodgrove Bank Mokelumne Hill", BankAccountNumber = "3256896325", PhoneNumber = "(209) 555-0108", FaxNumber = "(209) 555-0104", WebsiteURL = "http://www.litwareinc.com" });
            Suppliers.Add(new Supplier() { SupplierID = 8, SupplierName = "Lucerne Publishing", SupplierCategoryID = 2, DeliveryMethodID = 10, BankAccountBranch = "Woodgrove Bank Jonesborough", BankAccountNumber = "3254123658", PhoneNumber = "(423) 555-0103", FaxNumber = "(423) 555-0105", WebsiteURL = "http://www.lucernepublishing.com" });
            Suppliers.Add(new Supplier() { SupplierID = 9, SupplierName = "Nod Publishers", SupplierCategoryID = 2, DeliveryMethodID = 10, BankAccountBranch = "Woodgrove Bank Elizabeth City", BankAccountNumber = "2021545878", PhoneNumber = "(252) 555-0100", FaxNumber = "(252) 555-0101", WebsiteURL = "http://www.nodpublishers.com" });
            Suppliers.Add(new Supplier() { SupplierID = 10, SupplierName = "Northwind Electric Cars", SupplierCategoryID = 3, DeliveryMethodID = 8, BankAccountBranch = "Woodgrove Bank Crandon Lakes", BankAccountNumber = "3258786987", PhoneNumber = "(201) 555-0105", FaxNumber = "(201) 555-0104", WebsiteURL = "http://www.northwindelectriccars.com" });
            Suppliers.Add(new Supplier() { SupplierID = 11, SupplierName = "Trey Research", SupplierCategoryID = 8, BankAccountBranch = "Woodgrove Bank Kadoka", BankAccountNumber = "1254785321", PhoneNumber = "(605) 555-0103", FaxNumber = "(605) 555-0101", WebsiteURL = "http://www.treyresearch.net" });
            Suppliers.Add(new Supplier() { SupplierID = 12, SupplierName = "The Phone Company", SupplierCategoryID = 2, DeliveryMethodID = 7, BankAccountBranch = "Woodgrove Bank Karlstad", BankAccountNumber = "7896236589", PhoneNumber = "(218) 555-0105", FaxNumber = "(218) 555-0105", WebsiteURL = "http://www.thephone-company.com" });
            Suppliers.Add(new Supplier() { SupplierID = 13, SupplierName = "Woodgrove Bank", SupplierCategoryID = 7, BankAccountBranch = "Woodgrove Bank San Francisco", BankAccountNumber = "2147825698", PhoneNumber = "(415) 555-0103", FaxNumber = "(415) 555-0107", WebsiteURL = "http://www.woodgrovebank.com" });
            return Suppliers;
        }
        private List<SupplierCategory> CreateSupplierCategories() {
            List<SupplierCategory> SupplierCategories = new List<SupplierCategory>();
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 1, SupplierCategoryName = "Other Wholesaler" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 2, SupplierCategoryName = "Novelty Goods Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 3, SupplierCategoryName = "Toy Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 4, SupplierCategoryName = "Clothing Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 5, SupplierCategoryName = "Packaging Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 6, SupplierCategoryName = "Courier Services Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 7, SupplierCategoryName = "Financial Services Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 8, SupplierCategoryName = "Marketing Services Supplier" });
            SupplierCategories.Add(new SupplierCategory() { SupplierCategoryID = 9, SupplierCategoryName = "Insurance Services Supplier" });
            return SupplierCategories;
        }
        private List<DeliveryMethod> CreateDeliveryMethods() {
            List<DeliveryMethod> DeliveryMethods = new List<DeliveryMethod>();
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 1, DeliveryMethodName = "Post" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 2, DeliveryMethodName = "Courier" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 3, DeliveryMethodName = "Delivery Van" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 4, DeliveryMethodName = "Customer Collect" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 5, DeliveryMethodName = "Chilled Van" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 6, DeliveryMethodName = "Customer Courier to Collect" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 7, DeliveryMethodName = "Road Freight" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 8, DeliveryMethodName = "Air Freight" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 9, DeliveryMethodName = "Refrigerated Road Freight" });
            DeliveryMethods.Add(new DeliveryMethod() { DeliveryMethodID = 10, DeliveryMethodName = "Refrigerated Air Freight" });
            return DeliveryMethods;
        }
        IEnumerable<Supplier> InsertInternal(IDictionary<string, object> newValue) {
            var dataItem = new Supplier();
            Update(dataItem, newValue);
            dataItem.SupplierID = Suppliers.Last().SupplierID + 1;
            Suppliers.Add(dataItem);
            return Suppliers;
        }
        public Task<IEnumerable<Supplier>> Insert(IDictionary<string, object> newValue) {
            return Task.FromResult(InsertInternal(newValue));
        }
        IEnumerable<Supplier> RemoveInternal(Supplier dataItem) {
            Suppliers.Remove(dataItem);
            return Suppliers;
        }
        public Task<IEnumerable<Supplier>> Remove(Supplier dataItem) {
            return Task.FromResult(RemoveInternal(dataItem));
        }
        IEnumerable<Supplier> UpdateInternal(Supplier dataItem, IDictionary<string, object> newValue) {
            foreach(var field in newValue.Keys) {
                switch(field) {
                    case nameof(dataItem.DeliveryMethodID):
                        dataItem.DeliveryMethodID = (int)newValue[field];
                        break;
                    case nameof(dataItem.SupplierCategoryID):
                        dataItem.SupplierCategoryID = (int)newValue[field];
                        break;
                    case nameof(dataItem.BankAccountBranch):
                        dataItem.BankAccountBranch = (string)newValue[field];
                        break;
                    case nameof(dataItem.BankAccountNumber):
                        dataItem.BankAccountNumber = (string)newValue[field];
                        break;
                    case nameof(dataItem.FaxNumber):
                        dataItem.FaxNumber = (string)newValue[field];
                        break;
                    case nameof(dataItem.PhoneNumber):
                        dataItem.PhoneNumber = (string)newValue[field];
                        break;
                    case nameof(dataItem.SupplierName):
                        dataItem.SupplierName = (string)newValue[field];
                        break;
                    case nameof(dataItem.WebsiteURL):
                        dataItem.WebsiteURL = (string)newValue[field];
                        break;
                }
            }
            return Suppliers;
        }
        public Task<IEnumerable<Supplier>> Update(Supplier dataItem, IDictionary<string, object> newValue) {
            return Task.FromResult(UpdateInternal(dataItem, newValue));
        }
    }
}
