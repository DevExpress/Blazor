using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        public Task<IEnumerable<EditableEmployee>> GetEmployeesEditableAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetEmployeesEditableAsync(ct);
            /*EndHide*/
        }
        public Task InsertEmployeeAsync(IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.InsertEmployeeAsync(newValues);
            /*EndHide*/
        }
        public Task InsertEmployeeAsync(EditableEmployee newDataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.InsertEmployeeAsync(newDataItem);
            /*EndHide*/
        }
        public Task RemoveEmployeeAsync(EditableEmployee dataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.RemoveEmployeeAsync(dataItem);
            /*EndHide*/
        }
        public Task UpdateEmployeeAsync(EditableEmployee dataItem, IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.UpdateEmployeeAsync(dataItem, newValues);
            /*EndHide*/
        }
        public Task UpdateEmployeeAsync(EditableEmployee dataItem, EditableEmployee newDataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.UpdateEmployeeAsync(dataItem, newDataItem);
            /*EndHide*/
        }
    }
}
