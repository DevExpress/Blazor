using System;
using Newtonsoft.Json;

namespace BlazorDemo.Configuration {
    public class DemoPageBase : DemoPageSection {
        public DemoPage[] Pages { get; set; }
        public string Url { get; set; }
        public string SeoTitle { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }

        public string OG_Title { get; set; }
        public string OG_Image { get; set; }
        public string OG_Description { get; set; }
        public string OG_Url { get; set; }
        public string OG_Type { get; set; }

        public bool? ReCreateOnThemeChange { get; set; }

        public bool IsPreview { get; set; }
        public string PreviewMessage { get; set; }
        public bool IsMaintenanceMode { get; set; }
        public string MaintenanceModeMessage { get; set; }

        protected override DemoPageBase FindPage(Func<DemoPageBase, bool> findFunc) {
            if(findFunc(this))
                return this;
            return base.FindPage(findFunc);
        }
    }

    public class DemoRootPage : DemoPageBase {
        public string AnalyticsId { get; set; }
        public override string Uri => DemoConfiguration.GetRootDemoPageUrl(this);
    }

    public class DemoPage : DemoPageBase {
        public DemoPageSection[] PageSections { get; set; }
        [JsonIgnore]
        public DemoPageSection[] GetPageSections => DemoConfiguration.GetPageSections(this);
        [JsonIgnore]
        public override string Uri => Url;
    }
}
