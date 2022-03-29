using System;
using System.Collections.Generic;
using BlazorDemo.Data;
using BlazorDemo.Data.StockQuotes;

namespace BlazorDemo.Services {
    public class StockQuoteService : IStockQuoteService {
        public StockQuoteService() {
            StockQuotes = new StockQuote[] {
                new StockQuote("MMM", 170),
                new StockQuote("AXP", 160),
                new StockQuote("AAPL", 160),
                new StockQuote("BA", 205),
                new StockQuote("GS", 345),
                new StockQuote("INTC", 50),
                new StockQuote("NKE", 140),
                new StockQuote("UNH", 460),
                new StockQuote("WMT", 140),
                new StockQuote("DIS", 135)
            };
            Random = RandomWrapperFactory.Create();
        }

        IReadOnlyList<StockQuote> StockQuotes { get; }

        IRandomWrapper Random { get; }

        int CurrentIndex { get; set; }

        public event EventHandler<StockQuoteChangedEventArgs> StockQuoteChanged;

        public void GenerateChanges() {
#if VISUALTESTS
            foreach(var stockQuote in StockQuotes) {
                StockQuoteChanged?.Invoke(this, new StockQuoteChangedEventArgs(stockQuote));
            }
#else
            var alpha = 0.01M;
            CurrentIndex = (CurrentIndex + 1) % StockQuotes.Count;
            var stockQuote = StockQuotes[CurrentIndex];
            var openPrice = stockQuote.OpenPrice;
            var rawChange = Convert.ToDecimal(Random.NextDouble() - 0.5) * openPrice;
            stockQuote.Change = alpha * rawChange + (1 - alpha) * stockQuote.Change;
            stockQuote.LastUpdated = DateTime.Now;
            StockQuoteChanged?.Invoke(this, new StockQuoteChangedEventArgs(stockQuote));
#endif
        }
    }
}
