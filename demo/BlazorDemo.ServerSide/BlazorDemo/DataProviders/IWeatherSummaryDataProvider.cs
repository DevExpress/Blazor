using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IWeatherSummaryDataProvider {
        public Task<IEnumerable<DetailedWeatherSummary>> GetDataAsync(bool aggregateByMonth = false);
    }
}
