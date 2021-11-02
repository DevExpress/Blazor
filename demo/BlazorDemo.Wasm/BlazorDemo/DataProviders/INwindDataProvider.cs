using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;

namespace BlazorDemo.DataProviders {
    [Guid("61D165FE-4623-4D0C-A847-188EB1253D26")]
    public interface INwindDataProvider : IDataProvider {
        Task<IEnumerable<Category>> GetCategoriesAsync(CancellationToken ct = default);

        Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default);

        Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken ct = default);

        Task<IEnumerable<EditableEmployee>> GetEmployeesEditableAsync(CancellationToken ct = default);
        Task InsertEmployeeAsync(IDictionary<string, object> newValues, CancellationToken ct = default);
        Task InsertEmployeeAsync(EditableEmployee newDataItem, CancellationToken ct = default);
        Task RemoveEmployeeAsync(EditableEmployee dataItem, CancellationToken ct = default);
        Task UpdateEmployeeAsync(EditableEmployee dataItem, IDictionary<string, object> newValues, CancellationToken ct = default);
        Task UpdateEmployeeAsync(EditableEmployee dataItem, EditableEmployee newDataItem, CancellationToken ct = default);

        Task<IEnumerable<Invoice>> GetInvoicesAsync(CancellationToken ct = default);

        Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default);

        Task<IEnumerable<OrderDetail>> GetOrderDetailsAsync(CancellationToken ct = default);

        Task<IEnumerable<Product>> GetProductsAsync(CancellationToken ct = default);

        Task<IEnumerable<Shipper>> GetShippersAsync(CancellationToken ct = default);

        Task<IEnumerable<Supplier>> GetSuppliersAsync(CancellationToken ct = default);

        Task<IEnumerable<Supplier>> GetSuppliersEditableAsync(CancellationToken ct = default);
        Task InsertSupplierAsync(IDictionary<string, object> newValues, CancellationToken ct = default);
        Task InsertSupplierAsync(Supplier newDateItem, CancellationToken ct = default);
        Task RemoveSupplierAsync(Supplier dataItem, CancellationToken ct = default);
        Task UpdateSupplierAsync(Supplier dataItem, IDictionary<string, object> newValues, CancellationToken ct = default);
        Task UpdateSupplierAsync(Supplier dataItem, Supplier newDataItem, CancellationToken ct = default);
    }
}
