using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        public Task<IEnumerable<Supplier>> GetSuppliersEditableAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetSuppliersEditableAsync(ct);
            /*EndHide*/
        }
        public Task InsertSupplierAsync(IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.InsertSupplierAsync(newValues);
            /*EndHide*/
        }
        public Task InsertSupplierAsync(Supplier newDataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.InsertSupplierAsync(newDataItem);
            /*EndHide*/
        }
        public Task RemoveSupplierAsync(Supplier dataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.RemoveSupplierAsync(dataItem);
            /*EndHide*/
        }
        public Task UpdateSupplierAsync(Supplier dataItem, IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.UpdateSupplierAsync(dataItem, newValues);
            /*EndHide*/
        }
        public Task UpdateSupplierAsync(Supplier dataItem, Supplier newDataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.UpdateSupplierAsync(dataItem, newDataItem);
            /*EndHide*/
        }
    }
}
