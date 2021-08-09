using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class ContosoRetailDataProvider : EntityQueryableDataProvider<ContosoRetailContext>, IContosoRetailDataProvider {
        public ContosoRetailDataProvider(IDbContextFactory<ContosoRetailContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public IQueryable<Sale> GetSales() {
            return GetNonTrackingDbSet<Sale>();
        }

        public override Task<IObservable<int>> GetLoadingStateAsync() {
            if(ConnectionStringUtils.GetPivotGridLargeDataConnectionString(Configuration) == null)
                return Task.FromResult<IObservable<int>>(null);
            return base.GetLoadingStateAsync();
        }
    }
}
