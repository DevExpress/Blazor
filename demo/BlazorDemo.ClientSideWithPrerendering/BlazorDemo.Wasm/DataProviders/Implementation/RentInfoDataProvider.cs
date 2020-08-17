using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class RentInfoDataProvider : NotSupportedProvider, IRentInfoDataProvider {
        public Task<IEnumerable<AreaRentInfo>> GetAreaRentInfoAsync(CancellationToken ct = default) {
            throw new NotImplementedException();
        }
    }
}
