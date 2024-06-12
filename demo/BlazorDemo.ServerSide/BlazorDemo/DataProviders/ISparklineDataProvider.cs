using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ISparklineDataProvider {
        public List<SparklineGridDataRow> GenerateData();
    }
}
