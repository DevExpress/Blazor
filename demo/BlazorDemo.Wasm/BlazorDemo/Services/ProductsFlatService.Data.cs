using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class ProductsFlatService {
        public Task<IEnumerable<ProductFlat>> LoadAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _provider.LoadAsync(ct);
            /*EndHide*/
        }
        public Task<IEnumerable<ProductCategory>> LoadCategoriesAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _categoriesProvider.GetProductCategoriesAsync(ct);
            /*EndHide*/
        }
    }
}
