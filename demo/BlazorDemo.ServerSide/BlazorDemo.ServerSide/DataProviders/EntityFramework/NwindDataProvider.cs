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

        public async Task<IEnumerable<EditableEmployee>> GetEmployeesEditableAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Employee, EditableEmployee>("EmployeesEditable", ct);
        }
        public async Task InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            await InsertAsync<Employee, EditableEmployee>("EmployeesEditable", newValues, UpdateEmployeeKey, ct);
        }
        public async Task InsertEmployeeAsync(EditableEmployee newDateItem, CancellationToken ct = default) {
            await InsertAsync<Employee, EditableEmployee>("EmployeesEditable", newDateItem, UpdateEmployeeKey, ct);
        }
        public async Task UpdateEmployeeAsync(EditableEmployee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            await UpdateAsync<Employee, EditableEmployee>("EmployeesEditable", dataItem, newValues, FindEmployee, ct);
        }
        public async Task UpdateEmployeeAsync(EditableEmployee dataItem, EditableEmployee newDataItem, CancellationToken ct = default) {
            await UpdateAsync<Employee, EditableEmployee>("EmployeesEditable", dataItem, newDataItem, FindEmployee, ct);
        }
        public async Task RemoveEmployeeAsync(EditableEmployee dataItem, CancellationToken ct = default) {
            await RemoveAsync<Employee, EditableEmployee>("EmployeesEditable", dataItem, FindEmployee, ct);
        }
        static void UpdateEmployeeKey(IQueryable<Employee> items, Employee newItem) {
            UpdateItemKey(items, newItem, i => i.EmployeeId, (i, key) => i.EmployeeId = key);
        }
        static Employee FindEmployee(IQueryable<Employee> items, EditableEmployee item) {
            return items.Where(i => i.EmployeeId == item.EmployeeId).FirstOrDefault();
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
            await InsertAsync<Supplier>("SuppliersEditable", newValues, UpdateSupplierKey, ct);
        }
        public async Task InsertSupplierAsync(Supplier newDateItem, CancellationToken ct = default) {
            await InsertAsync<Supplier>("SuppliersEditable", newDateItem, UpdateSupplierKey, ct);
        }
        public async Task UpdateSupplierAsync(Supplier dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            await UpdateAsync<Supplier>("SuppliersEditable", dataItem, newValues, ct);
        }
        public async Task UpdateSupplierAsync(Supplier dataItem, Supplier newDataItem, CancellationToken ct = default) {
            await UpdateAsync<Supplier>("SuppliersEditable", dataItem, newDataItem, ct);
        }
        public async Task RemoveSupplierAsync(Supplier dataItem, CancellationToken ct = default) {
            await RemoveAsync<Supplier>("SuppliersEditable", dataItem, ct);
        }
        static void UpdateSupplierKey(IQueryable<Supplier> items, Supplier newItem) {
            UpdateItemKey(items, newItem, i => i.SupplierId, (i, key) => i.SupplierId = key);
        }
    }
}

