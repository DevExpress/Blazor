using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Worldcities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.DataProviders {
    class WorldcitiesDataProvider : DataProviderBase, IWorldcitiesDataProvider {
        private readonly WorldcitiesContext _context;

        public WorldcitiesDataProvider(WorldcitiesContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Countries", () => _context.Countries, null, ct);
        }
        public async Task<IEnumerable<City>> GetCitiesAsync(CancellationToken ct = default) {
            return await LoadDataAsync("Cities", () => _context.Cities, null, ct);
        }
    }
}

