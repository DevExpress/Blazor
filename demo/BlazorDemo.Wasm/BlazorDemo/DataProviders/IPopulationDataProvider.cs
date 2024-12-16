using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IPopulationDataProvider {
        public List<PopulationPoint> GetData();
    }
}
