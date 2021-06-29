using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class NwindDataProvider : EntityDataProvider<NorthwindContext>, INwindDataProvider {
        public NwindDataProvider(IDbContextFactory<NorthwindContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public async Task<IEnumerable<Category>> GetCategoriesAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Category>("Categories", ct);
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Customer>("Customers", ct);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Employee>("Employees", ct);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesEditableAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Employee>("EmployeesEditable", ct);
        }
        public async Task InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            await InsertAsync<Employee>("EmployeesEditable", newValues, UpdateEmployee, UpdateEmployeeKey, ct);
        }
        public async Task InsertEmployeeAsync(Employee dataItem, CancellationToken ct = default) {
            await InsertAsync<Employee>("EmployeesEditable", dataItem, UpdateEmployeeKey, ct);
        }
        public async Task UpdateEmployeeAsync(Employee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            await UpdateAsync<Employee>("EmployeesEditable", dataItem, newValues, UpdateEmployee, ct);
        }
        public async Task RemoveEmployeeAsync(Employee dataItem, CancellationToken ct = default) {
            await RemoveAsync<Employee>("EmployeesEditable", dataItem, ct);
        }
        static void UpdateEmployeeKey(IQueryable<Employee> items, Employee newItem) {
            UpdateItemKey(items, newItem, i => i.EmployeeId, (i, key) => i.EmployeeId = key);
        }
        static void UpdateEmployee(Employee item, string name, object value) {
            UpdateItem(item, name, value);
        }

        public async Task<IEnumerable<Invoice>> GetInvoicesAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Invoice>("Invoices", ct);
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Order>("Orders", ct);
        }

        public async Task<IEnumerable<OrderDetail>> GetOrderDetailsAsync(CancellationToken ct = default) {
            return await LoadDataAsync<OrderDetail>("OrderDetails", ct);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Product>("Products", ct);
        }

        public async Task<IEnumerable<Shipper>> GetShippersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Shipper>("Shippers", ct);
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Supplier>("Suppliers", ct);
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersEditableAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Supplier>("SuppliersEditable", ct);
        }
        public async Task InsertSupplierAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            await InsertAsync<Supplier>("SuppliersEditable", newValues, UpdateSupplier, UpdateSupplierKey, ct);
        }
        public async Task InsertSupplierAsync(Supplier dateItem, CancellationToken ct = default) {
            await InsertAsync<Supplier>("SuppliersEditable", dateItem, UpdateSupplierKey, ct);
        }
        public async Task UpdateSupplierAsync(Supplier dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            await UpdateAsync<Supplier>("SuppliersEditable", dataItem, newValues, UpdateSupplier, ct);
        }
        public async Task RemoveSupplierAsync(Supplier dataItem, CancellationToken ct = default) {
            await RemoveAsync<Supplier>("SuppliersEditable", dataItem, ct);
        }
        static void UpdateSupplierKey(IQueryable<Supplier> items, Supplier newItem) {
            UpdateItemKey(items, newItem, i => i.SupplierId, (i, key) => i.SupplierId = key);
        }
        static void UpdateSupplier(Supplier item, string name, object value) {
            UpdateItem(item, name, value);
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

