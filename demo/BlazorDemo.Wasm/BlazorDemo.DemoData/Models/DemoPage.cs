using System.Text.Json.Serialization;

namespace BlazorDemo.DemoData {
    public class DemoPage : DemoItem {
        public DemoPage[] Pages { get; set; }
        public DemoPageSection[] PageSections { get; set; }
        public string Url { get; set; }
        public string SeoTitle { get; set; }
        public string Keywords { get; set; }
        public string SearchKeywords { get; set; }
        public string Description { get; set; }
        public string SupportCenterId { get; set; }

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

        public string RazorFilesFolder { get; set; }
        public string DescriptionFilesFolder { get; set; }

        public override DemoItem[] GetChildItems() { return PageSections.Length > 0 ? PageSections : Pages; }
        public override IEnumerable<DemoItem> GetNavTreeChildren(bool demoMode) {
            return (PageSections.Length > 0 && ParentPage == null) ? PageSections : Pages;
        }
        public bool IsNavTreeVisible(bool siteMode) {
            return !IsMaintenanceMode && (!IsExternal || siteMode);
        }
        public string GetDescription() {
            return !string.IsNullOrEmpty(Description) ? Description : ParentPage?.GetDescription();
        }
        public string GetKeywords() {
            return !string.IsNullOrEmpty(Keywords) ? Keywords : ParentPage?.GetKeywords();
        }

        public override string GetUrl() {
            return Url;
        }
        public override string GetNavTreeUrl() {
            if(PageSections.Length > 0 && ParentPage == null) return string.Empty;
            return GetUrl();
        }
        public override string GetRazorFilesFolder() {
            if(RazorFilesFolder == null)
                return ParentPage?.GetRazorFilesFolder();
            return UniqueResourceId + (string.IsNullOrWhiteSpace(RazorFilesFolder) ? "" : "." + RazorFilesFolder);
        }
        public override string GetDescriptionFilesFolder() {
            if(DescriptionFilesFolder == null)
                return ParentPage?.GetDescriptionFilesFolder();
            return UniqueResourceId + (string.IsNullOrWhiteSpace(DescriptionFilesFolder) ? "" : "." + DescriptionFilesFolder);
        }
        protected override DemoItemStatus GetStatusCore() {
            if(IsPreview)
                return DemoItemStatus.Preview;
            if(IsMaintenanceMode)
                return DemoItemStatus.MaintenanceMode;
            return base.GetStatusCore();
        }

        protected override DemoPage FindPage(Func<DemoPage, bool> findFunc) {
            if(findFunc(this))
                return this;
            return base.FindPage(findFunc);
        }
    }
}
