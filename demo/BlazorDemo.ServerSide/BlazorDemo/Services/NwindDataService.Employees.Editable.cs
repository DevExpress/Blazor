using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        public Task<IEnumerable<Employee>> GetEmployeesEditableAsync(CancellationToken ct = default) {
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
        public Task InsertEmployeeAsync(Employee dataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.InsertEmployeeAsync(dataItem);
            /*EndHide*/
        }
        public Task RemoveEmployeeAsync(Employee dataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.RemoveEmployeeAsync(dataItem);
            /*EndHide*/
        }
        public Task UpdateEmployeeAsync(Employee dataItem, IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.UpdateEmployeeAsync(dataItem, newValues);
            /*EndHide*/
        }
    }
}
