using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Homes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class HomesDataProvider : EntityDataProvider<HomesContext>, IHomesDataProvider {
        public HomesDataProvider(IDbContextFactory<HomesContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public async Task<IEnumerable<Home>> GetHomesAsync(CancellationToken ct = default) {
             return await LoadDataAsync<Home>("Homes", ct);
        }
        public async Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Customer>("Customers", ct);
        }
        public async Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Order>("Orders", ct);
        }
    }
}

