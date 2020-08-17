using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("3BB51FA2-A107-4E10-B539-9CBC30DBED95")]
    public interface IProductCategoriesProvider : IDataProvider {
        Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync(CancellationToken ct = default);
    }
}
