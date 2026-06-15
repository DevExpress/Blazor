using System;
using System.Collections.Generic;
using BlazorDemo.Data.StockQuotes;
using DevExpress.Data.Utils;

namespace BlazorDemo.Services;

public class StockQuoteService : IStockQuoteService {
    readonly NonCryptographicRandom random = NonCryptographicRandom.System;
    protected IReadOnlyList<StockQuote> StockQuotes { get; } = [
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
    ];

    int CurrentIndex { get; set; }

    public event EventHandler<StockQuoteChangedEventArgs> StockQuoteChanged;

    public virtual void GenerateChanges() {
        var alpha = 0.01M;
        CurrentIndex = (CurrentIndex + 1) % StockQuotes.Count;
        var stockQuote = StockQuotes[CurrentIndex];
        var openPrice = stockQuote.OpenPrice;
        var rawChange = Convert.ToDecimal(random.NextDouble() - 0.5) * openPrice;
        stockQuote.Change = alpha * rawChange + (1 - alpha) * stockQuote.Change;
        stockQuote.LastUpdated = DateTime.Now;
        RaiseStockQuoteChanged(stockQuote);
    }

    protected void RaiseStockQuoteChanged(StockQuote stockQuote) =>
        StockQuoteChanged?.Invoke(this, new StockQuoteChangedEventArgs(stockQuote));
}
