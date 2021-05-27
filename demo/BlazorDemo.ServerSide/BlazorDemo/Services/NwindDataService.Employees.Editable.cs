using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        public Task<IEnumerable<Employee>> InsertEmployeeAsync(IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.InsertEmployeeAsync(newValues);
            /*EndHide*/
        }
        public Task<IEnumerable<Employee>> RemoveEmployeeAsync(Employee dataItem) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.RemoveEmployeeAsync(dataItem);
            /*EndHide*/
        }
        public Task<IEnumerable<Employee>> UpdateEmployeeAsync(Employee dataItem, IDictionary<string, object> newValues) {
            // Change your data here
            /*BeginHide*/
            return _dataProvider.UpdateEmployeeAsync(dataItem, newValues);
            /*EndHide*/
        }
    }
}
