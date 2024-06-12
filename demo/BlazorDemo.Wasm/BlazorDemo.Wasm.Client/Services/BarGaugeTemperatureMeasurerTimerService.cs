using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.Services {
    public class BarGaugeTemperatureMeasurerTimerService : IDisposable {

        public BarGaugeTemperatureMeasurerTimerService(BarGaugeTemperatureMeasurerService temperatureMeasurer) {
            TemperatureMeasurer = temperatureMeasurer;
            CancellationTokenSource = new CancellationTokenSource();
            _ = ExecuteAsync(CancellationTokenSource.Token);
        }

        BarGaugeTemperatureMeasurerService TemperatureMeasurer { get; }

        CancellationTokenSource CancellationTokenSource { get; }

        public void Dispose() {
            CancellationTokenSource.Cancel();
            CancellationTokenSource.Dispose();
        }

        async Task ExecuteAsync(CancellationToken token) {
            while(!token.IsCancellationRequested) {
                TemperatureMeasurer.MeasureTemperature();
                await Task.Delay(1500, token);
            }
        }
    }
}
