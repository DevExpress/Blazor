using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemo.DemoData;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.Configuration {
    public class DemoConfiguration {
        public const string DocBaseUrl = "https://docs.devexpress.com/Blazor/";
        public static readonly string PagesFolderName = "Pages";
        public static readonly string DescriptionsFolderName = "Descriptions";

        protected DemoConfiguration() {
        }
        public DemoConfiguration(IConfiguration configuration) {
            Configuration = configuration;
            Model = DemoModel.Create(IsServerSide);
            Search = new DemoSearchEngine(Model.Search, Groups);
        }

        private IConfiguration Configuration { get; set; }
        public DemoModel Model { get; private set; }
        public DemoSearchEngine Search { get; private set; }

        bool? isSiteMode;
        public bool IsSiteMode {
            get => isSiteMode ??= GetConfigurationValue<bool>("SiteMode");
        }

        bool? isSingleProduct;
        public bool IsSingleProduct {
            get => isSingleProduct ??= Groups.Count() < 2;
        }
        public bool IsServerSide =>
#if SERVER_BLAZOR
            true;
#else
            false;
#endif
        public virtual bool ShowOnlyReporting => false;

        public virtual IEnumerable<DemoProductInfo> Products { get => Model.Products; }
        public virtual IEnumerable<DemoGroup> Groups {
            get {
                return Model.Groups
                    .Where(g => g.GetNavTreeChildren(IsSiteMode).Any())
                    .Where(g => !ShowOnlyReporting || g.Category == GroupCategory.Reports);
            }
        }
        public Dictionary<string, string> Redirects { get { return Model.Redirects; } }

        public T GetConfigurationValue<T>(string key) {
            return Configuration.GetValue<T>(key);
        }

        public DemoPage GetDemoPageByUrl(NavigationManager navigationManager, string currentUrl) {
            var demoPageUrl = navigationManager.ToAbsoluteUri(currentUrl).GetLeftPart(UriPartial.Path).Replace(navigationManager.BaseUri, "");
            return Model.GetDemoPageByUrl(demoPageUrl);
        }
        public DemoItem GetDemoItem(string id) {
            return Model.GetDemoItem(id);
        }
        public DemoItem FindDemoItemRecursively(Func<DemoItem, bool> predicate) {
            return Model.FindDemoItemRecursively(predicate);
        }

        string GetDemoItemDescriptionResourcePath(DemoItem item) {
            return Model.GetDemoItemDescriptionResourcePath(item, PagesFolderName);
        }
        public string GetDemoDescription(DemoItem item) {
            string path = GetDemoItemDescriptionResourcePath(item);
            return GetDemoFileContent(path);
        }
        string GetDemoItemRazorResourcePath(DemoItem item) {
            return Model.GetDemoItemRazorResourcePath(item, PagesFolderName);
        }
        public Dictionary<string, string> GetDemoCodeFiles(DemoItem item) {
            var result = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            if(item.IsRazorFileVisible()) {
                string razorPath = GetDemoItemRazorResourcePath(item);
                result.Add("Razor", GetDemoFileContent(razorPath));
            }
            foreach(var codeFile in item.GetAdditionalCodeFiles()) {
                string codeFilePath = codeFile.Path.Replace("\\", ".");
                string codeFileContent = GetDemoFileContent(codeFilePath);
                result[codeFile.Title] = codeFile.GetPreparedContent(codeFileContent);
            }
            return result;
        }
        protected string GetDemoFileContent(string path) {
            return DemoUtils.GetFileContent(typeof(DemoConfiguration), "BlazorDemo." + path);
        }

        // Metadata
        public virtual void ConfigureMetadata(IDocumentMetadataCollection metadataCollection) {
            if(Model == null)
                return;

            metadataCollection.AddDefault()
                .Base("~/")
                .Charset("utf-8")
                .Viewport("width=device-width, initial-scale=1.0");

            var titleFormat = Model.TitleFormat ?? "{0}";
            foreach(var rootPage in Model.Groups.SelectMany(g => g.Pages)) {
                var title = rootPage.SeoTitle ?? rootPage.Title;
                ConfigurePage(metadataCollection, rootPage, title, titleFormat);
            }
        }
        static void ConfigurePage(IDocumentMetadataCollection metadataCollection, DemoPage page, string title, string titleFormat, bool stopIndexation = false) {
            if(page.Url != null && !page.IsMaintenanceMode) {
                var pageUrl = page.Url == "./" ? "" : page.Url;
                var metaBuilder = metadataCollection.AddPage(pageUrl)
                    .OpenGraph("url", page.OG_Url)
                    .OpenGraph("type", page.OG_Type)
                    .OpenGraph("title", page.OG_Title)
                    .OpenGraph("description", page.OG_Description)
                    .OpenGraph("image", page.OG_Image)
                    .Title(string.Format(titleFormat, title))
                    .Meta("description", page.GetDescription())
                    .Meta("keywords", page.GetKeywords());

                if(stopIndexation)
                    metaBuilder.Meta("robots", "none");
            }
            foreach(var subPage in page.Pages)
                ConfigurePage(metadataCollection, subPage, string.Join(" - ", title, subPage.Title), titleFormat, page.IsMaintenanceMode);
        }
        // Search
        public DemoSearchResult DoSearch(string request) {
            return Search.DoSearch(request);
        }
    }
}
