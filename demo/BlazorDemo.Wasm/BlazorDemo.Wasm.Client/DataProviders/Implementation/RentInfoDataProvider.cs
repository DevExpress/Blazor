using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class RentInfoDataProvider : NotSupportedProvider, IRentInfoDataProvider {
        public IQueryable<AreaRentInfo> GetAreaRentInfo() {
            throw new NotImplementedException();
        }
    }
}
