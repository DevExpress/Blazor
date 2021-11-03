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
            var list = await LoadDataAsync<Country>("Countries", ct);
            list.Sort((x, y) => string.Compare(x.CountryName, y.CountryName));
            return list;
        }
        public async Task<IEnumerable<City>> GetCitiesAsync(CancellationToken ct = default) {
            var list = await LoadDataAsync<City>("Cities", ct);
            list.Sort((x, y) => string.Compare(x.CityName, y.CityName));
            return list;
        }
    }
}

