using System;

namespace BlazorDemo.Data.StockQuotes {
    public class StockQuoteChangedEventArgs {
        public StockQuoteChangedEventArgs(StockQuote stockQuote) {
            Ticker = stockQuote.Ticker;
            OpenPrice = stockQuote.OpenPrice;
            Change = stockQuote.Change;
            LastUpdate = stockQuote.LastUpdated;
        }

        public string Ticker { get; set; }

        public decimal Change { get; set; }

        public decimal OpenPrice { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
