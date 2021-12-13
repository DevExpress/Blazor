using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BlazorDemo.Data {
    public static class GlobalTemperatureIndexCsvParser {
        public static List<GlobalTemperatureIndexInfo> Parse(string fileContent) {
            var list = new List<GlobalTemperatureIndexInfo>();
            using(StringReader reader = new StringReader(fileContent)) {
                string line;
                while((line = reader.ReadLine()) != null) {
                    string[] arr = line.Split(',');
                    list.Add(new GlobalTemperatureIndexInfo(
                        int.Parse(arr[0], CultureInfo.InvariantCulture),
                        double.Parse(arr[1], CultureInfo.InvariantCulture),
                        double.Parse(arr[2], CultureInfo.InvariantCulture)));
                }
            }
            return list;
        }
    }
}
