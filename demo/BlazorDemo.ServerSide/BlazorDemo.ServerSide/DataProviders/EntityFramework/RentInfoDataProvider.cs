using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class RentInfoDataProvider : EntityQueryableDataProvider<RentInfoContext>, IRentInfoDataProvider {
        public RentInfoDataProvider(IDbContextFactory<RentInfoContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public async Task<IEnumerable<AreaRentInfo>> GetAreaRentInfoAsync(CancellationToken ct = default) {
            return await LoadQueryableDataAsync<AreaRentInfo>(ct);
        }

        public override Task<IObservable<int>> GetLoadingStateAsync() {
            if(ConnectionStringUtils.GetGridLargeDataConnectionString(Configuration) == null)
                return Task.FromResult<IObservable<int>>(null);
            return base.GetLoadingStateAsync();
        }
    }
}
