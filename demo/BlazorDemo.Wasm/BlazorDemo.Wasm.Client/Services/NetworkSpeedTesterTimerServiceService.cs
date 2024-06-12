using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.Services {
    public class NetworkSpeedTesterTimerServiceTimerService : IDisposable {

        public NetworkSpeedTesterTimerServiceTimerService(NetworkSpeedTesterService netWorkTester) {
            NetWorkTester = netWorkTester;
            CancellationTokenSource = new CancellationTokenSource();
            _ = ExecuteAsync(CancellationTokenSource.Token);
        }

        NetworkSpeedTesterService NetWorkTester { get; }

        CancellationTokenSource CancellationTokenSource { get; }

        public void Dispose() {
            CancellationTokenSource.Cancel();
            CancellationTokenSource.Dispose();
        }

        async Task ExecuteAsync(CancellationToken token) {
            while(!token.IsCancellationRequested) {
                NetWorkTester.TestNetworkSpeed();
                await Task.Delay(1500, token);
            }
        }
    }
}
