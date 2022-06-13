using System;

namespace BlazorDemo.DemoData {
    public class DemoProductInfo {
        public string Title { get; set; }
        public string PageUri { get; set; }
        public string IconName { get; set; }
        public string Description { get; set; }
        public bool IsServerSideOnly { get; set; }
    }
}
