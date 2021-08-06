using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class ContosoRetailDataProvider : NotSupportedProvider, IContosoRetailDataProvider {
        public IQueryable<Sale> GetSales() {
            throw new NotImplementedException();
        }
    }
}
