using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public class BarGaugeTemperatureMeasurerService : IBarGaugeTemperatureMeasurerService {

        const double min_T = 105;
        const double max_T = 195;
        const double delta_Range = 50;

        IRandomWrapper rng = RandomWrapperFactory.Create();

        static BarGaugeTemperatureMeasureData LastMeasure { get; set; } = new BarGaugeTemperatureMeasureData(new List<double>() { 120, 140, 160, 180 });

        public event EventHandler<BarGaugeTemperatureMeasureData> DataReceived;

        public void MeasureTemperature() {
            /*BeginHide*/
#if !VISUALTESTS
            /*EndHide*/
            LastMeasure.Update(LastMeasure.Temperatures.Select(t => MeasureLineTemperature(t)));
            /*BeginHide*/
#endif
            /*EndHide*/
            DataReceived?.Invoke(this, LastMeasure);
        }

        double MeasureLineTemperature(double current) {
            double newT;

            do {
                var rnd = rng.NextDouble();
                var delta = delta_Range * (rnd - 0.5);
                newT = Math.Max(Math.Min(current + delta, max_T), min_T);
            }
            while(Math.Abs(current - newT) < 1);

            return newT;
        }
    }
}
