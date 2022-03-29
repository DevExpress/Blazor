using System;
using BlazorDemo.Data.StockQuotes;

namespace BlazorDemo.Services {
    public interface IStockQuoteService {
        event EventHandler<StockQuoteChangedEventArgs> StockQuoteChanged;
    }
}
