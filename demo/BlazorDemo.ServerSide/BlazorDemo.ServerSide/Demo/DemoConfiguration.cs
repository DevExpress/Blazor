using DevExpress.Blazor.DocumentMetadata;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Blazor {
    public class DemoPageConfiguration {
        public DemoPageConfiguration ParentPage { get; set; }

        public string Url { get; set; }
        public string Title { get; set; }
        public string TitleFormat { get; set; }
        public string Icon { get; set; }
        public string NavLinkText { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }


        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }

        public List<DemoPageConfiguration> DemoPages { get; set; } = new List<DemoPageConfiguration>();

        public string GetNavLinkText() => string.IsNullOrEmpty(NavLinkText) ? Title : NavLinkText;

        public string GetSeoTitle() => ParentPage == null ? Title : $"{ParentPage.GetSeoTitle()} - {Title}";
        public bool HasUpdates() => IsUpdated || DemoPages.Any(x => x.HasUpdates());
    }

    public class DemoConfiguration {
        public bool SiteMode { get; set; }
        public List<DemoPageConfiguration> DemoPages { get; set; } = new List<DemoPageConfiguration>();
        const string Description = "DevExpress UI for Blazor ships with native user interface components (including a Data Grid, Pivot Grid, Charts and Scheduler) so you can design rich user experiences with both Blazor.";

        public void RegisterPagesMetadata(IDocumentMetadataRegistrator registrator) {
            registrator.Default()
                .Base("~/")
                .Charset("utf-8")
                .TitleFormat("Blazor: {0} | DevExpress")
                .Viewport("width=device-width, initial-scale=1.0")

                .OpenGraph("url", "https://dxpr.es/2WogLq7")
                .OpenGraph("type", "website")
                .OpenGraph("title", "Native Blazor Components powered by DevExpress")
                .OpenGraph("description", Description)
                .OpenGraph("image", "https://static.devexpress.com/Products/Blazor/blazor-components-grid-pivot-scheduler-charts-editor-devexpress.jpg")

                .Meta("description", Description)

                .Script("highlight-js", "//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/highlight.min.js", defer: false)
                .Script("demo-js", "~/lib/dx-demo.js", defer: false)


                .StyleSheet("site-css", "~/css/site.css")
                .StyleSheet("highlight-css", "//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/styles/default.min.css")
                .StyleSheet("demo-css", "~/css/dx-demo.css")
                .StyleSheet("dx-css", "~/_content/DevExpress.Blazor/dx-blazor.css")
                .StyleSheet(
                    name: "currentTheme",
                    styleSheetUrl: "css/switcher-resources/themes/pulse/bootstrap.min.css"
                );

            DemoPages.ForEach(pageMetadata => {
                RegisterPageMetadata(registrator, pageMetadata);
            });
        }

        void RegisterPageMetadata(IDocumentMetadataRegistrator registrator, DemoPageConfiguration pageMetadata) {
            if (pageMetadata.Url != null) {
                IDocumentMetadataBuilder metadataBuilder = registrator.Page(pageMetadata.Url);
                metadataBuilder.Title(pageMetadata.GetSeoTitle());
                if (!string.IsNullOrEmpty(pageMetadata.TitleFormat))
                    metadataBuilder.TitleFormat(pageMetadata.TitleFormat);
                if(!string.IsNullOrEmpty(pageMetadata.Keywords))
                    metadataBuilder.Meta("keywords", pageMetadata.Keywords);
                if(!string.IsNullOrEmpty(pageMetadata.Description))
                    metadataBuilder.Meta("description", pageMetadata.Description);
            }
            foreach (var childPageMetadata in pageMetadata.DemoPages) {
                childPageMetadata.ParentPage = pageMetadata;
                RegisterPageMetadata(registrator, childPageMetadata);
            }
        }
    }
}