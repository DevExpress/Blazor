using System;

namespace BlazorDemo.Data.StockQuotes {
    public class StockQuote {
        public StockQuote(string ticker, decimal openPrice) {
            Ticker = ticker;
            OpenPrice = openPrice;
            Change = 0;
            LastUpdated = DateTime.Now;
        }

        public string Ticker { get; set; }

        public decimal Change { get; set; }

        public decimal OpenPrice { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
