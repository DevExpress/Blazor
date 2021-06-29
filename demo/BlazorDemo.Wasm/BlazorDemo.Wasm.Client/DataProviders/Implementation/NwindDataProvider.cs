using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;
using System.Reflection;

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

        public Task<IEnumerable<Employee>> GetEmployeesEditableAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetEmployeesEditableAsync);
        }
        public async Task InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            var employee = new Employee();
            foreach(var field in newValues.Keys)
                UpdateEmployee(employee, field, newValues[field]);
            await Loader.AddEntity(this, employee);
        }
        public async Task InsertEmployeeAsync(Employee dataItem, CancellationToken ct = default) {
            await Loader.AddEntity(this, dataItem);
        }
        public async Task RemoveEmployeeAsync(Employee dataItem, CancellationToken ct = default) {
            await Loader.DeleteEntity(this, dataItem);
        }
        public Task UpdateEmployeeAsync(Employee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            foreach(var field in newValues.Keys)
                UpdateEmployee(dataItem, field, newValues[field]);
            return Task.CompletedTask;
        }
        static void UpdateEmployee(Employee item, string name, object value) {
            UpdateItem(item, name, value);
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

        public Task<IEnumerable<Supplier>> GetSuppliersEditableAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetSuppliersEditableAsync);
        }
        public async Task InsertSupplierAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            var employee = new Supplier();
            foreach(var field in newValues.Keys)
                UpdateSupplier(employee, field, newValues[field]);
            await Loader.AddEntity(this, employee);
        }
        public async Task InsertSupplierAsync(Supplier dataItem, CancellationToken ct = default) {
            await Loader.AddEntity(this, dataItem);
        }
        public async Task RemoveSupplierAsync(Supplier dataItem, CancellationToken ct = default) {
            await Loader.DeleteEntity(this, dataItem);
        }
        public Task UpdateSupplierAsync(Supplier dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            foreach(var field in newValues.Keys)
                UpdateSupplier(dataItem, field, newValues[field]);
            return Task.CompletedTask;
        }
        static void UpdateSupplier(Supplier item, string name, object value) {
            UpdateItem(item, name, value);
        }

        public NwindDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }

        static void UpdateItem<T>(T item, string name, object value) {
            var prop = typeof(T).GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            if(prop != null)
                prop.SetValue(item, value);
        }
        static void UpdateItemKey<T>(IQueryable<T> items, T newItem, Func<T, int> getKey, Action<T, int> setKey) {
            var lastItem = items.OrderBy(getKey).LastOrDefault();
            setKey(newItem, lastItem != null ? getKey(lastItem) + 1 : 1);
        }
    }
}
