using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class EmployeeTaskEditableDataProvider : EmployeeTaskDataProvider, IEmployeeTaskEditableDataProvider {
        /*BeginHide*/
        List<EmployeeTask> _lastGeneratedTasks;
        List<EmployeeTask> LastGeneratedTasks {
            get {
                if(_lastGeneratedTasks == null) {
                    _lastGeneratedTasks = GenerateData();
                }
                return _lastGeneratedTasks;
            }
        }
        /*EndHide*/

        public Task<List<EmployeeTask>> GetEmployeeTasks() {
            // Return your data here
            /*BeginHide*/
            return Task.FromResult(LastGeneratedTasks);
            /*EndHide*/
        }
        public Task InsertEmployeeTask(EmployeeTask newDataItem) {
            // Change your data here
            /*BeginHide*/
            LastGeneratedTasks.Add(newDataItem);
            return Task.CompletedTask;
            /*EndHide*/
        }
        public Task RemoveEmployeeTask(EmployeeTask dataItem) {
            // Change your data here
            /*BeginHide*/
            var dataItemToRemove = LastGeneratedTasks.FirstOrDefault(t => t.Id == dataItem.Id);
            LastGeneratedTasks.Remove(dataItemToRemove);
            return Task.CompletedTask;
            /*EndHide*/
        }
        public Task UpdateEmployeeTask(EmployeeTask updatedDataItem) {
            // Change your data here
            /*BeginHide*/
            var dataItemToUpdate = LastGeneratedTasks.FirstOrDefault(t => t.Id == updatedDataItem.Id);
            UpdateItemProperties(dataItemToUpdate, updatedDataItem);
            return Task.CompletedTask;
            /*EndHide*/
        }
        /*BeginHide*/
        protected void UpdateItemProperties<T, T1>(T item, T1 sourceItem) where T : class, new() {
            var props = typeof(T1).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            foreach(var prop in props)
                UpdateItemProperty(item, prop.Name, prop.GetValue(sourceItem));
        }
        protected void UpdateItemProperty<T>(T item, string name, object value) where T : class, new() {
            var prop = typeof(T).GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            if(prop != null && prop.CanWrite)
                prop.SetValue(item, value);
        }
        /*EndHide*/
    }
}
