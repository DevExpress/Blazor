namespace BlazorDemo.DemoData {
    public class DemoPageSection : DemoItem {
        public override string GetUrl() {
            return ParentPage.GetUrl() + "#" + Id;
        }
        public override string GetNavTreeUrl() {
            return GetUrl();
        }
        public override DemoItem[] GetChildItems() {
            return Array.Empty<DemoPageSection>();
        }
        public override IEnumerable<DemoItem> GetNavTreeChildren(bool demoMode) { return Enumerable.Empty<DemoItem>(); }
        public override string GetRazorFilesFolder() {
            return ParentPage?.GetRazorFilesFolder();
        }
        public override string GetDescriptionFilesFolder() {
            return ParentPage?.GetDescriptionFilesFolder();
        }
    }
}
