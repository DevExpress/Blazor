using Newtonsoft.Json;
using System.Linq;

namespace BlazorDemo.DemoData {
    public abstract class DemoPageBase : DemoItem {
        public DemoPage[] Pages { get; set; }

        public string Url { get; set; }
        public string SeoTitle { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }

        public bool IsPreview { get; set; }
        public string PreviewMessage { get; set; }
        public bool IsMaintenanceMode { get; set; }
        public string MaintenanceModeMessage { get; set; }

        public string OG_Title { get; set; }
        public string OG_Image { get; set; }
        public string OG_Description { get; set; }
        public string OG_Url { get; set; }
        public string OG_Type { get; set; }

        public bool? ReCreateOnThemeChange { get; set; }

        public string GetDescription() {
            return !string.IsNullOrEmpty(Description) ? Description : ParentPage?.GetDescription();
        }
        public string GetKeywords() {
            return !string.IsNullOrEmpty(Keywords) ? Keywords : ParentPage?.GetKeywords();
        }

        public override string GetUrl() { return !string.IsNullOrEmpty(Url) ? Url : Pages.Select(p => p.GetUrl()).FirstOrDefault(); }
        protected override DemoItemStatus GetStatusCore() {
            if(IsPreview)
                return DemoItemStatus.Preview;
            if(IsMaintenanceMode)
                return DemoItemStatus.MaintenanceMode;
            return base.GetStatusCore();
        }
        protected override DemoPageBase FindPage(Func<DemoPageBase, bool> findFunc) {
            if(findFunc(this))
                return this;
            return base.FindPage(findFunc);
        }
    }
}
