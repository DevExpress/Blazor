using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IRangeSelectorZoomingDataProvider {
        public List<ZoomingData> GetData();
    }
}
