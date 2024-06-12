using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.DataProviders.Implementation;
using Microsoft.Extensions.Hosting;

namespace BlazorDemo.Services {
    public class BarGaugeTemperatureMeasurerTimerService : BackgroundService {
        public BarGaugeTemperatureMeasurerTimerService(BarGaugeTemperatureMeasurerService temperatureMeasurer) {
            TemperatureMeasurer = temperatureMeasurer;
        }

        BarGaugeTemperatureMeasurerService TemperatureMeasurer { get; }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            while(!stoppingToken.IsCancellationRequested) {
                TemperatureMeasurer.MeasureTemperature();
                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
