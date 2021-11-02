using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IPopulationStructureDataProvider {
        public Task<IEnumerable<PopulationAgeStructureItem>> QueryData();
    }
}
