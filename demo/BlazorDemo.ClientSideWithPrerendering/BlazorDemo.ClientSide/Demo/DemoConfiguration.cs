using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Routing;
using System;
using DevExpress.Blazor.DocumentMetadata;
using System.Linq;

namespace Demo.Blazor
{
    public class DemoPageConfiguration
    {
        public DemoPageConfiguration ParentPage { get; set; }

        public string Url { get; set; }
        public string Title { get; set; }
        public string TitleFormat { get; set; }
        public string Icon { get; set; }
        public string NavLinkText { get; set; }


        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }

        public List<DemoPageConfiguration> DemoPages { get; set; } = new List<DemoPageConfiguration>();

        public string GetNavLinkText() => string.IsNullOrEmpty(NavLinkText) ? Title : NavLinkText;

        public string GetSeoTitle() => ParentPage == null ? Title : $"{ParentPage.GetSeoTitle()} - {Title}";
        public bool HasUpdates() => IsUpdated || DemoPages.Any(x => x.HasUpdates());
    }

    public class DemoConfiguration
    {
        public bool SiteMode { get; set; }

        public List<DemoPageConfiguration> DemoPages { get; }

        public DemoConfiguration()
        {
            DemoPages = new List<DemoPageConfiguration>();
            PopulateDemoPages();
        }

        public void RegisterPagesMetadata(IDocumentMetadataRegistrator registrator)
        {
            registrator.Default()
                .Base("~/")
                .Charset("utf-8")
                .TitleFormat("Blazor: {0} | DevExpress")
                .Viewport("width=device-width, initial-scale=1.0")
                .OpenGraph("url", "https://dxpr.es/2WogLq7")
                .OpenGraph("type", "website")
                .OpenGraph("title", "Native Blazor Components powered by DevExpress")
                .OpenGraph("description", "Free DevExpress UI for Blazor ships with 7 user interface components (including a Data Grid and Pivot Grid) so you can design rich user experiences with both Blazor.")
                .OpenGraph("image", "https://static.devexpress.com/Products/Blazor/blazor-demo-social.png")
                .Meta("twitter:card", "summary")
                .Meta("twitter:site", "@@devexpress")

                .Script("highlight-js", "//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/highlight.min.js", defer: true)
                .Script("demo-js", "~/lib/dx-demo.js", defer: true)
                .Script("dx-blazor-js", "~/lib/dx-blazor/dx-blazor.js", defer: true)

                .Script("facebook-jssdk", "https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.0", async: true)
                .Script("twitter-js", "https://platform.twitter.com/widgets.js", async: true)

                .StyleSheet("site-css", "~/css/site.css")
                .StyleSheet("highlight-css", "//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/styles/default.min.css")
                .StyleSheet("demo-css", "~/css/dx-demo.css")
                .StyleSheet("dx-css", "~/lib/dx-blazor/dx-blazor.css")
                .StyleSheet(
                    name: "currentTheme",
                    styleSheetUrl: "css/switcher-resources/themes/pulse/bootstrap.min.css"
                );

            DemoPages.ForEach(pageMetadata =>
            {
                RegisterPageMetadata(registrator, pageMetadata);
            });
        }

        void RegisterPageMetadata(IDocumentMetadataRegistrator registrator, DemoPageConfiguration pageMetadata)
        {
            if (pageMetadata.Url != null)
            {
                IDocumentMetadataBuilder metadataBuilder = registrator.Page(pageMetadata.Url);
                metadataBuilder.Title(pageMetadata.GetSeoTitle());
                if (!string.IsNullOrEmpty(pageMetadata.TitleFormat))
                    metadataBuilder.TitleFormat(pageMetadata.TitleFormat);
            }
            foreach (var childPageMetadata in pageMetadata.DemoPages)
            {
                childPageMetadata.ParentPage = pageMetadata;
                RegisterPageMetadata(registrator, childPageMetadata);
            }
        }

        void PopulateDemoPages()
        {
            DemoPages.Add(new DemoPageConfiguration() {
                Url = "",
                Title = "Blazor UI Components",
                NavLinkText = "Overview",
                Icon = "images/Overview.svg",
                TitleFormat = "Demos: {0} | DevExpress"
            });
            var gridPages = new DemoPageConfiguration() { Title = "Grid" };
            gridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "GridColumnTypes",
                Title = "Column Types",
                Icon = "images/GridColumnType.svg"
            });
            gridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "GridTemplate",
                Title = "Templates",
                Icon = "images/GridTemplates.svg"
            });
            gridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "GridCascadingEditors",
                Title = "Cascading Editors",
                Icon = "images/GridCascadingEditors.svg",
                IsNew = true
            });
            gridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "GridEditFormTemplateValidation",
                Title = "Edit Form Validation",
                Icon = "images/GridEditFormTemplate.svg",
                IsNew = true
            });
            gridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "GridLargeDataBase",
                Title = "Large Data Source",
                Icon = "images/GridLargeData.svg"
            });
            DemoPages.Add(gridPages);
            
            var pivotGridPages = new DemoPageConfiguration() { Title = "Pivot Grid" };
            pivotGridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "PivotGrid",
                Title = "Overview",
                Icon = "images/PivotGrid.svg"
            });
            pivotGridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "PivotGridTemplates",
                Title = "Templates",
                Icon = "images/PivotGridTemplate.svg"
            });
            pivotGridPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "PivotGridLargeDataBase",
                Title = "Large Data",
                Icon = "images/PivotGridLargeData.svg"
            });
            DemoPages.Add(pivotGridPages);

            var editorPages = new DemoPageConfiguration() { Title = "Editors" };
            editorPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "ComboBox",
                Title = "Combo Box",
                IsUpdated = true
            });
            editorPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "SpinEdit",
                Title = "Spin Edit"
            });
            editorPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "DateEdit",
                Title = "Date Edit"
            });
            editorPages.DemoPages.Add(new DemoPageConfiguration() {
                Url = "TextBox",
                Title = "Text Box"
            });
            DemoPages.Add(editorPages);

            DemoPages.Add(new DemoPageConfiguration() {
                Url = "FormLayout",
                Title = "Form Layout",
                Icon = "images/FormLayout.svg"
            });
            DemoPages.Add(new DemoPageConfiguration() {
                Url = "FormValidation",
                Title = "Form Validation",
                Icon = "images/GridColumnType.svg"
            });
            DemoPages.Add(new DemoPageConfiguration() {
                Url = "Tabs",
                Title = "Tabs",
                Icon = "images/Tabs.svg"
            });
            DemoPages.Add(new DemoPageConfiguration() {
                Url = "TreeView",
                Title = "Tree View",
                Icon = "images/TreeView.svg",
                IsNew = true
            });
            DemoPages.Add(new DemoPageConfiguration() {
                Url = "Editors",
                Title = "Editors",
                Icon = "images/Editors.svg",
                IsUpdated = true
            });
            DemoPages.Add(new DemoPageConfiguration() {
                Url = "Pager",
                Title = "Pager",
                Icon = "images/Pager.svg"
            });
        }
    }
}