using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class NwindDataProvider : RemoteDataProviderBase, INwindDataProvider {
        public Task<IEnumerable<Category>> GetCategoriesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetCategoriesAsync);
        }

        public Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetCustomersAsync);
        }

        public Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetEmployeesAsync);
        }
        public async Task<IEnumerable<Employee>> InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            var employee = new Employee();
            foreach(var field in newValues.Keys)
                UpdateEmployee(employee, field, newValues[field]);
            await Loader.AddEntity(this, employee);
            return await Loader.LoadRemoteEntities(this, GetEmployeesAsync);
        }
        public async Task<IEnumerable<Employee>> RemoveEmployeeAsync(Employee dataItem, CancellationToken ct = default) {
            await Loader.DeleteEntity(this, dataItem);
            return await Loader.LoadRemoteEntities(this, GetEmployeesAsync);
        }
        public async Task<IEnumerable<Employee>> UpdateEmployeeAsync(Employee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            foreach(var field in newValues.Keys)
                UpdateEmployee(dataItem, field, newValues[field]);
            return await Loader.LoadRemoteEntities(this, GetEmployeesAsync);
        }
        static void UpdateEmployee(Employee item, string name, object value) {
            switch(name) {
                case "FirstName":
                    item.FirstName = (string)value;
                    return;
                case "LastName":
                    item.LastName = (string)value;
                    return;
                case "Title":
                    item.Title = (string)value;
                    return;
                case "TitleOfCourtesy":
                    item.TitleOfCourtesy = (string)value;
                    return;
                case "BirthDate":
                    item.BirthDate = (DateTime)value;
                    return;
                case "HireDate":
                    item.HireDate = (DateTime)value;
                    return;
            }
        }

        public Task<IEnumerable<Invoice>> GetInvoicesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetInvoicesAsync);
        }

        public Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetOrdersAsync);
        }

        public Task<IEnumerable<OrderDetail>> GetOrderDetailsAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetOrderDetailsAsync);
        }

        public Task<IEnumerable<Product>> GetProductsAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetProductsAsync);
        }

        public Task<IEnumerable<Shipper>> GetShippersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetShippersAsync);
        }

        public Task<IEnumerable<Supplier>> GetSuppliersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetSuppliersAsync);
        }

        public NwindDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
