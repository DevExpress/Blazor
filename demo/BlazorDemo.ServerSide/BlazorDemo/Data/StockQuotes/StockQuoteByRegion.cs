using System;

namespace BlazorDemo.Data.StockQuotes {
    public class StockQuoteByRegion {
        public StockQuoteByRegion(int id, int parentId, string ticker, decimal openPrice) {
            Id = id;
            ParentId = parentId;
            Ticker = ticker;
            OpenPrice = openPrice;
            Change = 0;
            LastUpdated = DateTime.Now;
        }

        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Ticker { get; set; }

        public decimal Change { get; set; }

        public decimal OpenPrice { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
