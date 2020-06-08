using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class RentInfoDataProvider : DataProviderBase, IRentInfoDataProvider, IDisposable {
        private readonly FMRDemoContext _context;
        readonly IConfiguration _configuration;

        

        public RentInfoDataProvider(FMRDemoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<IEnumerable<AreaRentInfo>> GetAreaRentInfoAsync(CancellationToken ct = default) {
            await Task.Delay(150, ct).ConfigureAwait(false);
            
            return _context.AreaRentInfo.AsNoTracking();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
        
        public override Task<IObservable<int>> GetLoadingStateAsync()
        {
            if (_configuration.GetConnectionString("GridLargeDataConnectionString") == "{Remote demo database connection string}")
                return Task.FromResult<IObservable<int>>(null);
            return base.GetLoadingStateAsync();
        }
    }
}