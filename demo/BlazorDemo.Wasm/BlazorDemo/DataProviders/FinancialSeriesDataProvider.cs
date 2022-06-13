using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class FinancialSeriesDataProvider : IFinancialSeriesDataProvider {
        const double StartPrice = 6;
        const double MaxPrice = 100;
        const double MinPrice = 5;

        static StockDataPoint GeneratePoint(DateTime dateTime, double previousClose, Random random) {
            double open = previousClose + (random.NextDouble() - 0.5) / 25d;
            double close = open + (random.NextDouble() - 0.5) / 5d;
            if(close > MaxPrice)
                close = 0.8 * close;
            if(close <= MinPrice)
                close = 2 * MinPrice - close;
            double high = Math.Max(open, close) + random.NextDouble() / 5d;
            double low = Math.Min(open, close) - random.NextDouble() / 5d;
            return new StockDataPoint(dateTime, open, high, low, close);
        }
        IEnumerable<StockDataPoint> GenerateInternal() {
            Random random = new Random(28);
            List<StockDataPoint> points = new List<StockDataPoint>();
            DateTime now = DateTime.Now.Date;
            DateTime currentDateTime = now.AddMinutes(-90);
            DateTime endDateTime = now;
            double previousClose = StartPrice;
            while(currentDateTime < endDateTime) {
                StockDataPoint point = GeneratePoint(currentDateTime, previousClose, random);
                previousClose = point.Close;
                currentDateTime = currentDateTime.AddSeconds(2);
                points.Add(point);
            }
            return points;
        }

        public Task<IEnumerable<StockDataPoint>> Generate() {
            return Task.Run(GenerateInternal);
        }
    }
}
