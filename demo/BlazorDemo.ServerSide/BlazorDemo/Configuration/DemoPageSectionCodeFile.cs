using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Configuration {
    public class DemoPageSectionCodeFile {
        public string Title { get; set; }
        public string Path { get; set; }
        public string ExtractRegex { get; set; }
        public string[] ExtractRegexGroups { get; set; }
    }
}
