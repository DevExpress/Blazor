using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.DataProviders {
    class NwindDataProvider : DataProviderBase, INwindDataProvider {
        private readonly NorthwindContext _context;

        public NwindDataProvider(NorthwindContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Categories", () => _context.Categories, null, ct);
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Customers", () => _context.Customers, null, ct);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Employees", () => _context.Employees, UpdateEmployee, ct);
        }
        public async Task<IEnumerable<Employee>> InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default) {
            return await InsertAsync<Employee>("Employees", newValues, ct);
        }
        public async Task<IEnumerable<Employee>> RemoveEmployeeAsync(Employee dataItem, CancellationToken ct = default) {
            return await RemoveAsync<Employee>("Employees", dataItem, ct);
        }
        public async Task<IEnumerable<Employee>> UpdateEmployeeAsync(Employee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) {
            return await UpdateAsync<Employee>("Employees", dataItem, newValues, ct);
        }
        static void UpdateEmployee(Employee item, string name, object value) {
            var prop = typeof(Employee).GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            if(prop != null)
                prop.SetValue(item, value);
        }

        public async Task<IEnumerable<Invoice>> GetInvoicesAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Invoices", () => _context.Invoices, null, ct);
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Orders", () => _context.Orders, null, ct);
        }

        public async Task<IEnumerable<OrderDetail>> GetOrderDetailsAsync(CancellationToken ct = default) {
            return await LoadDataAsync("OrderDetails", () => _context.OrderDetails, null, ct);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Products", () => _context.Products, null, ct);
        }

        public async Task<IEnumerable<Shipper>> GetShippersAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Shippers", () => _context.Shippers, null, ct);
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Suppliers", () => _context.Suppliers, null, ct);
        }
    }
}

