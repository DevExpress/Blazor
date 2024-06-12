using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace BlazorDemo.Services {
    public class NetworkSpeedTesterTimerService : BackgroundService {
        public NetworkSpeedTesterTimerService(NetworkSpeedTesterService netWorkTester) {
            NetWorkTester = netWorkTester;
        }

        NetworkSpeedTesterService NetWorkTester { get; }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            while(!stoppingToken.IsCancellationRequested) {
                NetWorkTester.TestNetworkSpeed();
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
