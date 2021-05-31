using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data {
    public class Vacancy {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }
    public class Location {
        public string City { get; set; }
        public string Region { get; set; }
    }
}
