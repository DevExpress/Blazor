using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.Services {
    public class StockQuoteChangeTimerService : IDisposable {

        public StockQuoteChangeTimerService(StockQuoteService stockQuoteService) {
            StockQuoteService = stockQuoteService;
            CancellationTokenSource = new CancellationTokenSource();
            _ = ExecuteAsync(CancellationTokenSource.Token);
        }

        StockQuoteService StockQuoteService { get; }

        CancellationTokenSource CancellationTokenSource { get; }

        public void Dispose() {
            CancellationTokenSource.Cancel();
            CancellationTokenSource.Dispose();
        }

        async Task ExecuteAsync(CancellationToken token) {
            while(!token.IsCancellationRequested) {
                StockQuoteService.GenerateChanges();
                await Task.Delay(500, token);
            }
        }
    }
}
