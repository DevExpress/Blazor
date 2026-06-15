namespace BlazorDemo.Services;

public class VisualTestsStockQuoteService : StockQuoteService {
    public override void GenerateChanges() {
        foreach(var stockQuote in StockQuotes) {
            RaiseStockQuoteChanged(stockQuote);
        }
    }
}

public class VisualTestsStockQuoteByRegionService : StockQuoteByRegionService {
    public override void GenerateChanges() {
        foreach(var stockQuote in StockQuotes) {
            RaiseStockQuoteChanged(stockQuote);
        }
    }
}
