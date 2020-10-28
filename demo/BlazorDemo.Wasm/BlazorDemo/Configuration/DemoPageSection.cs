using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Configuration {
    public class DemoPageSection {
        public string Id { get; set; }
        public string Title { get; set; }
        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }
    }
}
