using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlazorDemo.DemoData {
    public class DemoPageSection : DemoItem {
        public override string GetUrl() {
            return ParentPage.GetUrl() + "#" + Id;
        }
        public override DemoItem[] GetChildItems() {
            return Array.Empty<DemoPageSection>();
        }
        public override string GetRazorFilesFolder() {
            return ParentPage?.GetRazorFilesFolder();
        }
        public override string GetDescriptionFilesFolder() {
            return ParentPage?.GetDescriptionFilesFolder();
        }
    }
}
