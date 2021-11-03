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

        public Task<IEnumerable<EditableEmployee>> GetEmployeesEditableAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetEmployeesEditableAsync);
        }
        public async Task InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            var employee = new EditableEmployee();
            UpdateItemProperties(employee, newValues);
            await Loader.AddEntity(this, employee);
        }
        public async Task InsertEmployeeAsync(EditableEmployee newDataItem, CancellationToken ct = default) {
            await Loader.AddEntity(this, newDataItem);
        }
        public async Task RemoveEmployeeAsync(EditableEmployee dataItem, CancellationToken ct = default) {
            await Loader.DeleteEntity(this, dataItem);
        }
        public Task UpdateEmployeeAsync(EditableEmployee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            UpdateItemProperties(dataItem, newValues);
            return Task.CompletedTask;
        }
        public Task UpdateEmployeeAsync(EditableEmployee dataItem, EditableEmployee newDataItem, CancellationToken ct = default) {
            UpdateItemProperties(dataItem, newDataItem);
            return Task.CompletedTask;
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
            var supplier = new Supplier();
            UpdateItemProperties(supplier, newValues);
            await Loader.AddEntity(this, supplier);
        }
        public async Task InsertSupplierAsync(Supplier newDataItem, CancellationToken ct = default) {
            await Loader.AddEntity(this, newDataItem);
        }
        public async Task RemoveSupplierAsync(Supplier dataItem, CancellationToken ct = default) {
            await Loader.DeleteEntity(this, dataItem);
        }
        public Task UpdateSupplierAsync(Supplier dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            UpdateItemProperties(dataItem, newValues);
            return Task.CompletedTask;
        }
        public Task UpdateSupplierAsync(Supplier dataItem, Supplier newDataItem, CancellationToken ct = default) {
            UpdateItemProperties(dataItem, newDataItem);
            return Task.CompletedTask;
        }

        public NwindDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }

#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
        protected void UpdateItemProperties<T>(T item, T newItem) where T : class, new() {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            foreach(var prop in props)
                UpdateItemProperty(item, prop.Name, prop.GetValue(newItem));
        }
        protected void UpdateItemProperties<T>(T item, IDictionary<string, object> values) where T : class, new() {
            foreach(var field in values.Keys)
                UpdateItemProperty(item, field, values[field]);
        }
        protected void UpdateItemProperty<T>(T item, string name, object value) where T : class, new() {
            var prop = typeof(T).GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            if(prop != null && prop.CanWrite)
                prop.SetValue(item, value);
        }
        protected static void UpdateItemKey<T>(IQueryable<T> items, T newItem, Func<T, int> getKey, Action<T, int> setKey) {
            var lastItem = items.OrderBy(getKey).LastOrDefault();
            setKey(newItem, lastItem != null ? getKey(lastItem) + 1 : 1);
        }
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type
    }
}
