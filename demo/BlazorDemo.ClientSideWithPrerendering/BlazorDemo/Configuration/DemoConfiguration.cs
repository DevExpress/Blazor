using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace BlazorDemo.Configuration {
    public class DemoConfiguration {
        private readonly SeoConfiguration _seoConfig;

        public DemoConfiguration(IOptions<SeoConfiguration> seoOptions, IConfiguration configuration) {
            _seoConfig = seoOptions?.Value;
            if(_seoConfig == null) return;
            if (_seoConfig.RootDemoPages == null)
                _seoConfig = configuration.GetSection("BlazorDemo")?.Get<SeoConfiguration>();

            
            bool IsReportsDemoModule(Assembly x) => x.GetName().Name == "BlazorDemo.Reporting";

            AdditionalRoutingAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(IsReportsDemoModule).ToArray();
            Products = _seoConfig.Products ?? new DemoProductInfo[0];
        }

        public bool IsReportingModuleLoaded => AdditionalRoutingAssemblies.Any();

        public void ConfigureMetadata(IDocumentMetadataCollection metadataCollection) {
            if (_seoConfig == null) return;

            metadataCollection.AddDefault()
                .Base("~/")
                .Charset("utf-8")
                .Viewport("width=device-width, initial-scale=1.0");

            if (_seoConfig.RootDemoPages != null) {
                foreach (var page in _seoConfig.RootDemoPages) {
                    ConfigurePage(metadataCollection, page, page.Title, _seoConfig.TitleFormat ?? "{0}");
                }
            }
        }

        public IEnumerable<Assembly> AdditionalRoutingAssemblies { get; }
        public IEnumerable<DemoProductInfo> Products { get; }


        static void ConfigurePage(IDocumentMetadataCollection metadataCollection, DemoPage page, string title, string titleFormat) {
            if (page.Url != null) {
                metadataCollection.AddPage(page.Url)
                    .OpenGraph("url", page.OG_Url)
                    .OpenGraph("type", page.OG_Type)
                    .OpenGraph("title", page.OG_Title)
                    .OpenGraph("description", page.OG_Description)
                    .OpenGraph("image", page.OG_Image)
                    .Title(string.Format(titleFormat, title))
                    .Meta("description", page.Description);
            }

            if (page.DemoPages != null) {
                foreach (var demoPage in page.DemoPages)
                    ConfigurePage(metadataCollection, demoPage, string.Join('-', title, demoPage.Title), titleFormat);
            }
        }
    }
}