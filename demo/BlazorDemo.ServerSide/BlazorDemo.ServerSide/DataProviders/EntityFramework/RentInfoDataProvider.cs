using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class RentInfoDataProvider : EntityQueryableDataProvider<RentInfoContext>, IRentInfoDataProvider {
        public RentInfoDataProvider(IDbContextFactory<RentInfoContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public IQueryable<AreaRentInfo> GetAreaRentInfo() {
            return GetNonTrackingDbSet<AreaRentInfo>();
        }

        public override Task<IObservable<int>> GetLoadingStateAsync() {
            if(ConnectionStringUtils.GetGridLargeDataConnectionString(Configuration) == null)
                return Task.FromResult<IObservable<int>>(null);
            return base.GetLoadingStateAsync();
        }
    }
}
