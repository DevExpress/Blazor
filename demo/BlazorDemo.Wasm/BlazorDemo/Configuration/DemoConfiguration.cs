using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace BlazorDemo.Configuration {
    public class DemoConfiguration {
        private readonly SeoConfiguration _seoConfig;

        public DemoConfiguration(IOptions<SeoConfiguration> seoOptions, IConfiguration configuration) {
            _seoConfig = seoOptions?.Value;
            if(_seoConfig == null) return;
            if(_seoConfig.RootDemoPages == null)
                _seoConfig = configuration.GetSection("BlazorDemo")?.Get<SeoConfiguration>();

            if(_seoConfig == null) return;
            bool IsReportsDemoModule(Assembly x) => x.GetName().Name == "BlazorDemo.Reporting";

            AdditionalRoutingAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(IsReportsDemoModule).ToArray();
            Products = _seoConfig.Products ?? new DemoProductInfo[0];
        }

        public bool IsReportingModuleLoaded =>
#if NETCOREAPP3
            true;
#else
            false;
#endif
        public bool ShowOnlyReporting => false;
        public void ConfigureMetadata(IDocumentMetadataCollection metadataCollection) {
            if(_seoConfig == null) return;

            metadataCollection.AddDefault()
                .Base("~/")
                .Charset("utf-8")
                .Viewport("width=device-width, initial-scale=1.0");

            if(_seoConfig.RootDemoPages != null) {
                foreach(var page in _seoConfig.RootDemoPages) {
                    ConfigurePage(metadataCollection, page, page.Title, _seoConfig.TitleFormat ?? "{0}");
                }
            }
        }

        public IEnumerable<Assembly> AdditionalRoutingAssemblies { get; }
        public IEnumerable<DemoProductInfo> Products { get; }

        public IEnumerable<DemoPageSection> GetDemoPageSections(string pageUrl, out DemoPage demoPage) {
            demoPage = null;
            foreach(var rootPage in _seoConfig.RootDemoPages) {
                if(rootPage.DemoPages != null)
                    demoPage = rootPage.DemoPages.FirstOrDefault(p => string.Equals(p.Url, pageUrl, StringComparison.OrdinalIgnoreCase));
                if(string.Equals(rootPage.Url, pageUrl, StringComparison.OrdinalIgnoreCase))
                    demoPage = rootPage;
                if(demoPage != null)
                    return demoPage.DemoPageSections ?? new DemoPageSection[0];
            }
            
            return new DemoPageSection[0];
        }

        static void ConfigurePage(IDocumentMetadataCollection metadataCollection, DemoPage page, string title, string titleFormat) {
            if(page.Url != null) {
                metadataCollection.AddPage(page.Url)
                    .OpenGraph("url", page.OG_Url)
                    .OpenGraph("type", page.OG_Type)
                    .OpenGraph("title", page.OG_Title)
                    .OpenGraph("description", page.OG_Description)
                    .OpenGraph("image", page.OG_Image)
                    .Title(string.Format(titleFormat, title))
                    .Meta("description", page.Description)
                    .Meta("keywords", page.Keywords);
            }

            if(page.DemoPages != null) {
                foreach(var demoPage in page.DemoPages)
                    ConfigurePage(metadataCollection, demoPage, string.Join('-', title, demoPage.Title), titleFormat);
            }
        }
    }
}
