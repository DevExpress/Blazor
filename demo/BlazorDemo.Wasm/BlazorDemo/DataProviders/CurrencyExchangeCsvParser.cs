using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BlazorDemo.Data {
    public static class CurrencyExchangeCsvParser {
        public static List<DatePricePoint> Parse(string fileContent) {
            var list = new List<DatePricePoint>();
            using(StringReader reader = new StringReader(fileContent)) {
                string line;
                while((line = reader.ReadLine()) != null) {
                    string[] arr = line.Split(',');
                    var day = DateTime.ParseExact(arr[0], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var value = double.Parse(arr[1], CultureInfo.InvariantCulture);
                    list.Add(new DatePricePoint(day, value));
                }
            }
            return list;
        }
    }
}
