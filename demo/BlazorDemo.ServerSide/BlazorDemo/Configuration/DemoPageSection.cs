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
        public bool IsServerSideOnly { get; set; }
        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }

        public string GetStatusMessageMarkdown() {
            var page = FindPage(page => page.IsPreview);
            if(page != null) {
                if(!string.IsNullOrEmpty(page.PreviewMessage))
                    return page.PreviewMessage;
                return string.Format("The {0} is currently available as a community technology preview [(CTP)](https://www.devexpress.com/aboutus/pre-release.xml).", page.Title);
            }
            page = FindPage(page => page.IsMaintenanceMode);
            if(page != null) {
                if(!string.IsNullOrEmpty(page.MaintenanceModeMessage))
                    return page.MaintenanceModeMessage;
                return string.Format("The {0} was moved to maintenance support mode. No new features/capabilities will be added to this component.", page.Title);
            }
            return string.Empty;
        }
        protected virtual DemoPageBase FindPage(Func<DemoPageBase, bool> findFunc) {
            var page = ParentPage;
            while(page != null) {
                if(findFunc(page))
                    return page;
                page = page.ParentPage;
            }
            return null;
        }

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
