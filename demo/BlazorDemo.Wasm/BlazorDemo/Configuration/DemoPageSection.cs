using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BlazorDemo.Configuration {
    public class DemoPageSection {
        public string[] RedirectFrom { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string TitleOnPage { get; set; }
        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsPreview { get; set; }
        public string DocUrl { get; set; }
        public DemoPageSectionCodeFile[] AdditionalCodeFiles { get; set; }
        public bool ShowRazorFile { get; set; } = true;
        public string DescriptionFileContent { get; set; }
        public Dictionary<string, MarkupString> CodeFilesContent { get; set; }
        [JsonIgnore]
        public DemoPageBase ParentPage { get; set; }
        [JsonIgnore]
        public virtual string Uri { get { return ParentPage.Uri + "#" + Id; } }
    }
}
