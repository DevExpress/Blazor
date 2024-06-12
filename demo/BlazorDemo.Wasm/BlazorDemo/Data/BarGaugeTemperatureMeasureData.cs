using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {
    public class BarGaugeTemperatureMeasureData {

        public BarGaugeTemperatureMeasureData(IEnumerable<double> temperatures) {
            Update(temperatures);
        }
        public List<double> Temperatures { get; private set; }

        public void Update(IEnumerable<double> temperatures) {
            Temperatures = temperatures.ToList();
        }
    }
}
