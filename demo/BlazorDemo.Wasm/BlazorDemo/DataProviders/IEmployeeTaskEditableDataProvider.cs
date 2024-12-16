using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IEmployeeTaskEditableDataProvider {
        Task<List<EmployeeTask>> GetEmployeeTasks();
        Task InsertEmployeeTask(EmployeeTask newDataItem);
        Task RemoveEmployeeTask(EmployeeTask dataItem);
        Task UpdateEmployeeTask(EmployeeTask updatedDataItem);
    }
}
