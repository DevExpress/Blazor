using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("3513A30A-DBAD-4F5C-8D8E-4434A24888B0")]
    public interface IProductsProvider : IDataProvider {
        Task<IEnumerable<Product>> LoadAsync(CancellationToken ct = default);
        Task RemoveAsync(Product product);
        Task AddAsync(Product product);
    }
}
