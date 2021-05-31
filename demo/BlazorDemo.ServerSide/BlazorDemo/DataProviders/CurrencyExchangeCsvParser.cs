using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BlazorDemo.Data {
    public static class CurrencyExchangeCsvParser {
        public static List<BargainDataPoint> Parse(string fileContent) {
            var list = new List<BargainDataPoint>();
            using(StringReader reader = new StringReader(fileContent)) {
                string line;
                while((line = reader.ReadLine()) != null) {
                    string[] arr = line.Split(',');
                    var day = DateTime.ParseExact(arr[0], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var value = double.Parse(arr[1], CultureInfo.InvariantCulture);
                    list.Add(new BargainDataPoint(day, value));
                }
            }
            return list;
        }
    }
}
