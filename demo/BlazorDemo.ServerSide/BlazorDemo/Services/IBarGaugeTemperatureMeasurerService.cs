using System;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public interface IBarGaugeTemperatureMeasurerService {
        event EventHandler<BarGaugeTemperatureMeasureData> DataReceived;
    }
}
