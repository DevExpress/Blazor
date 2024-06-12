using System;

namespace BlazorDemo.Data.StockQuotes {
    public class StockQuoteByRegionChangedEventArgs {
        public StockQuoteByRegionChangedEventArgs(StockQuoteByRegion stockQuote) {
            Id = stockQuote.Id;
            ParentId = stockQuote.ParentId;
            Ticker = stockQuote.Ticker;
            OpenPrice = stockQuote.OpenPrice;
            Change = stockQuote.Change;
            LastUpdate = stockQuote.LastUpdated;
        }

        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Ticker { get; set; }

        public decimal Change { get; set; }

        public decimal OpenPrice { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
