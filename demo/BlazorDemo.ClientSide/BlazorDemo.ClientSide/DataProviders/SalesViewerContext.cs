using System.Collections.Generic;
using BlazorDemo.Data.SalesViewer;

namespace BlazorDemo.DataProviders.Implementation {
    class SalesViewerContext {
        public SalesViewerContext() {
            Channels = new List<Channel>();
            Cities = new List<City>();
            Contacts = new List<Contact>();
            Customers = new List<Customer>();
            Plants = new List<Plant>();
            Products = new List<Product>();
            Regions = new List<Region>();
            Sales = new List<Sale>();
            Sectors = new List<Sector>();
        }

        public virtual List<Channel> Channels { get; set; }
        public virtual List<City> Cities { get; set; }
        public virtual List<Contact> Contacts { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual List<Plant> Plants { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Region> Regions { get; set; }
        public virtual List<Sale> Sales { get; set; }
        public virtual List<Sector> Sectors { get; set; }
    }
}
