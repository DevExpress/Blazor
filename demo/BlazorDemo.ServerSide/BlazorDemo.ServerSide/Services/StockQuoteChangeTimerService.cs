using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.Services {
    public class StockQuoteChangeTimerService : BackgroundService {
        public StockQuoteChangeTimerService(StockQuoteService stockQuoteService) {
            StockQuoteService = stockQuoteService;
        }

        StockQuoteService StockQuoteService { get; }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            while(!stoppingToken.IsCancellationRequested) {
                StockQuoteService.GenerateChanges();
                await Task.Delay(500, stoppingToken);
            }
        }
    }
}
