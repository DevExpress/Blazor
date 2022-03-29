using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorDemo.Data.StockQuotes {
    public class StockQuoteDisplayModel : INotifyPropertyChanged {

        string _ticker;

        decimal _lastPrice;

        decimal _change;

        decimal _percentageChange;

        DateTime _lastUpdated;

        public string Ticker {
            get => _ticker;
            set => SetPropertyValue(ref _ticker, value);
        }

        public decimal LastPrice {
            get => _lastPrice;
            set => SetPropertyValue(ref _lastPrice, value);
        }

        public decimal Change {
            get => _change;
            set => SetPropertyValue(ref _change, value);
        }

        public decimal PercentageChange {
            get => _percentageChange;
            set => SetPropertyValue(ref _percentageChange, value);
        }

        public DateTime LastUpdated {
            get => _lastUpdated;
            set => SetPropertyValue(ref _lastUpdated, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void SetPropertyValue<T>(ref T property, T value, [CallerMemberName] string propertyName = "") {
            if(EqualityComparer<T>.Default.Equals(property, value))
                return;

            property = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
