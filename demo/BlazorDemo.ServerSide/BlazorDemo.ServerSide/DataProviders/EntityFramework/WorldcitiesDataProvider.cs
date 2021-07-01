using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Worldcities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    class WorldcitiesDataProvider : EntityDataProvider<WorldcitiesContext>, IWorldcitiesDataProvider {
        public WorldcitiesDataProvider(IDbContextFactory<WorldcitiesContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public async Task<IEnumerable<Country>> GetCountriesAsync(CancellationToken ct = default) {
            return await LoadDataAsync<Country>("Countries", ct);
        }
        public async Task<IEnumerable<City>> GetCitiesAsync(CancellationToken ct = default) {
            return await LoadDataAsync<City>("Cities", ct);
        }
    }
}

