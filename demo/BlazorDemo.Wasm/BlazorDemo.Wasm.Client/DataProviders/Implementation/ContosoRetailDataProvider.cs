using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class ContosoRetailDataProvider : NotSupportedProvider, IContosoRetailDataProvider {
        public Task<IEnumerable<Sale>> GetSalesAsync(CancellationToken ct = default) {
            throw new NotImplementedException();
        }
    }
}
