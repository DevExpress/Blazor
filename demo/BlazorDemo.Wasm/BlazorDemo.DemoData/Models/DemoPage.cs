using Newtonsoft.Json;
using System;

namespace BlazorDemo.DemoData {
    public class DemoPage : DemoPageBase {
        public DemoPageSection[] PageSections { get; set; }

        public override DemoItem[] GetChildItems() { return (PageSections.Length > 0) ? PageSections : Pages; }
    }
}
