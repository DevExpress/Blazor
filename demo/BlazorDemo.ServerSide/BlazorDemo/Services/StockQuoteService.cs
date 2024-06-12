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

        protected IReadOnlyList<StockQuote> StockQuotes { get; set; }

        IRandomWrapper Random { get; }

        int CurrentIndex { get; set; }

        public event EventHandler<StockQuoteChangedEventArgs> StockQuoteChanged;

        public virtual void GenerateChanges() {
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

    public class StockQuoteByRegionService : IStockQuoteByRegionService {
        public StockQuoteByRegionService() {
            StockQuotes = new StockQuoteByRegion[] {
                new StockQuoteByRegion(1, 0, "US", 0),
                new StockQuoteByRegion(2, 1, "Dow Jones", 37775),
                new StockQuoteByRegion(3, 1, "S&P", 5011),
                new StockQuoteByRegion(4, 1, "Nasdaq", 15601),
                new StockQuoteByRegion(5, 1, "Russell", 1942),
                new StockQuoteByRegion(6, 1, "VIX", 18),

                new StockQuoteByRegion(7, 0, "Europe", 0),
                new StockQuoteByRegion(8, 7, "DAX", 17837),
                new StockQuoteByRegion(9, 7, "FTSE 100", 7877),
                new StockQuoteByRegion(10, 7, "CAC 40", 8023),
                new StockQuoteByRegion(11, 7, "IBEX 35", 10765),
                new StockQuoteByRegion(12, 7, "STOXX 50", 4936),

                new StockQuoteByRegion(13, 0, "Asia", 0),
                new StockQuoteByRegion(14, 13, "Nikkei 225", 37068),
                new StockQuoteByRegion(15, 13, "SSE", 3058),
                new StockQuoteByRegion(16, 13, "HSI", 16218),
                new StockQuoteByRegion(17, 13, "SENSEX", 72237),
                new StockQuoteByRegion(18, 13, "NIFTY 50", 21914),
            };
            Random = RandomWrapperFactory.Create();
        }

        protected IReadOnlyList<StockQuoteByRegion> StockQuotes { get; set; }

        IRandomWrapper Random { get; }

        int CurrentIndex { get; set; }

        public event EventHandler<StockQuoteByRegionChangedEventArgs> StockQuoteChanged;

        public virtual void GenerateChanges() {
#if VISUALTESTS
            foreach(var stockQuote in StockQuotes) {
                StockQuoteChanged?.Invoke(this, new StockQuoteByRegionChangedEventArgs(stockQuote));
            }
#else
            var alpha = 0.01M;
            CurrentIndex = (CurrentIndex + 1) % StockQuotes.Count;
            var stockQuote = StockQuotes[CurrentIndex];
            var openPrice = stockQuote.OpenPrice;
            var rawChange = Convert.ToDecimal(Random.NextDouble() - 0.5) * openPrice;
            stockQuote.Change = alpha * rawChange + (1 - alpha) * stockQuote.Change;
            stockQuote.LastUpdated = DateTime.Now;
            StockQuoteChanged?.Invoke(this, new StockQuoteByRegionChangedEventArgs(stockQuote));
#endif
        }
    }

}
