using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class FinancialSeriesDataProvider : IFinancialSeriesDataProvider {
        const double StartPrice = 6;

        static BargainDataPoint GeneratePoint(DateTime dateTime, double previousPrice, Random random) {
            double price = previousPrice + (random.NextDouble() - 0.5) / 25d;
            return new BargainDataPoint(dateTime, price);
        }
        IEnumerable<BargainDataPoint> GenerateInternal() {
            Random random = new Random(28);
            List<BargainDataPoint> points = new List<BargainDataPoint>();
            DateTime now = DateTime.Now.Date;
            DateTime currentDateTime = now.AddMinutes(-90);
            DateTime endDateTime = now;
            double previousPrice = StartPrice;
            while(currentDateTime < endDateTime) {
                BargainDataPoint point = GeneratePoint(currentDateTime, previousPrice, random);
                previousPrice = point.Price;
                currentDateTime = currentDateTime.AddSeconds(2);
                points.Add(point);
            }
            return points;
        }

        public Task<IEnumerable<BargainDataPoint>> Generate() {
            return Task.Run(GenerateInternal);
        }
    }
}
