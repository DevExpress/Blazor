using System;
using BlazorDemo.Data.StockQuotes;
namespace BlazorDemo.Services;

public interface IStockQuoteByRegionService {
    event EventHandler<StockQuoteByRegionChangedEventArgs> StockQuoteChanged;
}
