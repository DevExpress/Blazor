using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartBirthLifeDataProvider {
        public List<BirthLife> GenerateData();
    }
}
