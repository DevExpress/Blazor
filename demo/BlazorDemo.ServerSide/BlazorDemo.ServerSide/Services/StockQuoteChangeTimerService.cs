using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace BlazorDemo.Services {
    public class StockQuoteChangeTimerService : BackgroundService {
        public StockQuoteChangeTimerService(StockQuoteService stockQuoteService, StockQuoteByRegionService stockQuoteByRegionService) {
            StockQuoteService = stockQuoteService;
            StockQuoteByRegionService = stockQuoteByRegionService;
        }

        StockQuoteService StockQuoteService { get; }
        StockQuoteByRegionService StockQuoteByRegionService { get; }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            while(!stoppingToken.IsCancellationRequested) {
                StockQuoteService.GenerateChanges();
                StockQuoteByRegionService.GenerateChanges();
                await Task.Delay(500, stoppingToken);
            }
        }
    }
}
