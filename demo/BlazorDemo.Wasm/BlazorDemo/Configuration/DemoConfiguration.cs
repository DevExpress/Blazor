using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace BlazorDemo.Configuration {
    public class DemoConfiguration {
        public const string DocBaseUrl = "https://docs.devexpress.com/Blazor/";
        public static readonly string ConfigJsonPath = "wwwroot.demo-metadata.json";
        public static readonly string PagesFolderName = "Pages";
        public static readonly string DescriptionsFolderName = "Descriptions";

        public static string GetRootDemoPageUrl(DemoRootPage rootPage) {
            return !string.IsNullOrEmpty(rootPage.Url) ? rootPage.Url : rootPage.Pages.Select(p => p.Url).FirstOrDefault();
        }

        public static bool ArePagesAsSections(DemoPageBase basePage) {
            return basePage.Pages != null && basePage.Pages.Length > 0;
        }

        public static DemoPageSection[] GetPageSections(DemoPage basePage) {
            return basePage.PageSections.Length > 0 ? basePage.PageSections : (ArePagesAsSections(basePage) ? basePage.Pages : Array.Empty<DemoPageSection>());
        }

        protected DemoConfiguration() {
        }
        public DemoConfiguration(IConfiguration configuration) {
            Configuration = configuration;

            var jsonContent = GetDemoFileContent(ConfigJsonPath);
            Data = JsonConvert.DeserializeObject<DemoConfigurationData>(jsonContent);
            if(Data == null)
                return;

            Products = Data.Products = PrepareList(Data.Products);
            RootPages = Data.RootPages = PrepareList(Data.RootPages);
            Redirect = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            ConnectRecursive(RootPages, null);
            Search = new DemoSearchHelper(Data.Search, RootPages);

            void ConnectRecursive(IEnumerable<DemoPageSection> childSections, DemoPageBase parent) {
                foreach(var section in childSections) {
                    if(section is DemoPageBase pageBase) {
                        pageBase.Pages = PrepareList(pageBase.Pages);
                        ConnectRecursive(pageBase.Pages, pageBase);
                    }
                    if(section is DemoPage page) {
                        page.PageSections = PrepareList(page.PageSections);
                        ConnectRecursive(page.PageSections, page);
                    }
                    section.ParentPage = parent;
                    if(section.RedirectFrom?.Length > 0) {
                        foreach(var redirect in section.RedirectFrom)
                            Redirect.Add(redirect, section.Uri);
                    }
                }
            }

            T[] PrepareList<T>(T[] list) {
                if(list == null)
                    return Array.Empty<T>();
                IEnumerable<T> result = list;
                if(!IsServerSide) {
                    result = result
                        .Where(i => i switch {
                            DemoProductInfo info => !info.IsServerSideOnly,
                            DemoPageSection section => !section.IsServerSideOnly,
                            _ => throw new NotSupportedException()
                        });
                }
                return result
                    .OrderBy(i => i is DemoPageBase page ? page.IsMaintenanceMode : false)
                    .ToArray();
            }
        }

        private IConfiguration Configuration { get; set; }
        public DemoConfigurationData Data { get; private set; }
        public DemoSearchHelper Search { get; private set; }

        public bool IsServerSide =>
#if SERVER_BLAZOR
            true;
#else
            false;
#endif
        public virtual bool ShowOnlyReporting => false;

        public virtual IEnumerable<DemoProductInfo> Products { get; }
        public virtual IEnumerable<DemoRootPage> RootPages { get; }
        public Dictionary<string, string> Redirect { get; private set; }

        public T GetConfigurationValue<T>(string key) {
            return Configuration.GetValue<T>(key);
        }

        public DemoPageBase GetDemoPageByUrl(string pageUrl) {
            pageUrl = pageUrl.Trim('/');

            DemoPageBase FindRecursive(IEnumerable<DemoPageBase> pages) {
                if(pages == null)
                    return null;
                foreach(var page in pages) {
                    if(string.Equals(page.Url, pageUrl, StringComparison.OrdinalIgnoreCase))
                        return page;
                    var nestedResult = FindRecursive(page.Pages);
                    if(nestedResult != null)
                        return nestedResult;
                }
                return null;
            }

            return FindRecursive(Data.RootPages);
        }
        public DemoPageBase GetDemoPageByUrl(NavigationManager navigationManager, string currentUrl) {
            var demoPageUrl = navigationManager.ToAbsoluteUri(currentUrl).GetLeftPart(UriPartial.Path).Replace(navigationManager.BaseUri, "");
            return GetDemoPageByUrl(demoPageUrl);
        }

        public DemoPage GetDemoPage(string id) {
            string[] idParts = GetIdParts(id);
            var rootDemoPage = Data.RootPages.FirstOrDefault(p => p.Id == idParts[0]);
            if(rootDemoPage != null)
                return rootDemoPage.Pages.FirstOrDefault(p => p.Id == idParts[1]);
            throw new ArgumentException(string.Format("A page with the '{0}' key doesn't exist", id));
        }
        public DemoPageSection GetDemoPageSection(string id, DemoPage demoPage = null) {
            string[] idParts = GetIdParts(id);
            if(demoPage == null)
                demoPage = GetDemoPage(id);
            if(demoPage != null) {
                var sections = demoPage.GetPageSections;
                return sections.FirstOrDefault(p => idParts.Length == 2 || p.Id == idParts[2]);
            }

            return null;
        }
        public string GetDemoPageSectionDescription(string id) {
            string[] idParts = GetIdParts(id);
            string folder = string.Join(".", new string[] { PagesFolderName, idParts[0], idParts[1] });
            string fileName = id + ".md";
            string path = string.Join(".", new string[] { folder, DescriptionsFolderName, fileName });
            return GetDemoFileContent(path);
        }
        public Dictionary<string, string> GetDemoPageSectionCodeFiles(DemoPageSection section) {
            var result = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            if(section.ShowRazorFile) {
                string sectionId = section.Id;
                string pageId = section.ParentPage != null ? section.ParentPage.Id : "";
                string rootPageId = section.ParentPage != null && section.ParentPage.ParentPage != null ? section.ParentPage.ParentPage.Id : "";
                if(string.IsNullOrEmpty(rootPageId)) {
                    rootPageId = pageId;
                    pageId = sectionId;
                }
                string razorFolder = string.Join(".", new string[] { PagesFolderName, rootPageId, pageId });
                string razorFileName = rootPageId + "-" + pageId + (pageId != sectionId ? "-" + sectionId : "") + ".razor";
                string razorPath = string.Join(".", new string[] { razorFolder, razorFileName });
                result.Add("Razor", GetDemoFileContent(razorPath));
            }
            if(section != null && section.AdditionalCodeFiles != null) {
                foreach(var codeFile in section.AdditionalCodeFiles) {
                    string codeFilePath = codeFile.Path.Replace("\\", ".");
                    string codeFileContent = GetDemoFileContent(codeFilePath);
                    if(!string.IsNullOrWhiteSpace(codeFile.ExtractRegex) && !string.IsNullOrWhiteSpace(codeFileContent)) {
                        var matches = new Regex(codeFile.ExtractRegex)
                                            .Matches(codeFileContent)
                                            .Where(m => m.Success)
                                            .ToArray();
                        if(matches.Length > 0) {
                            codeFileContent = string.Join("\n", matches.Select(m => {
                                if(codeFile.ExtractRegexGroups?.Length > 0) {
                                    var groupValues = "";
                                    foreach(var group in codeFile.ExtractRegexGroups) {
                                        if(m.Groups[group].Success)
                                            groupValues += m.Groups[group].Value;
                                    }

                                    if(!string.IsNullOrEmpty(groupValues))
                                        return groupValues;
                                }

                                return m.Value;
                            }));
                        } else
                            Console.Error.WriteLine($"No match in reqex {codeFile.ExtractRegex} in file {codeFilePath}");
                    }
                    result[codeFile.Title] = codeFileContent;
                }
            }
            return result;
        }
        protected string GetDemoFileContent(string path) {
            string content = string.Empty;
            using(var stream = GetResourceStream(path)) {
                if(stream != null) {
                    using(var sr = new StreamReader(stream))
                        content = sr.ReadToEnd();
                }
            }
            return content;
        }
        protected Stream GetResourceStream(string path) {
            return Assembly.GetAssembly(typeof(DemoConfiguration)).GetManifestResourceStream("BlazorDemo." + path);
        }
        protected string[] GetIdParts(string id) {
            string[] idParts = id.Split("-");
            if(idParts.Length != 2 && idParts.Length != 3)
                throw new ArgumentException(string.Format("'{0}' isn't a valid Id for a demo section. It must be in the following formats - 'product-category-demo' or 'product-demo'", id));
            return idParts;
        }
        // Metadata
        public virtual void ConfigureMetadata(IDocumentMetadataCollection metadataCollection) {
            if(Data == null)
                return;

            metadataCollection.AddDefault()
                .Base("~/")
                .Charset("utf-8")
                .Viewport("width=device-width, initial-scale=1.0");

            var titleFormat = Data.TitleFormat ?? "{0}";
            foreach(var rootPage in Data.RootPages) {
                var title = rootPage.SeoTitle ?? rootPage.Title;
                ConfigurePage(metadataCollection, rootPage, title, titleFormat);
                foreach(var page in rootPage.Pages)
                    ConfigurePage(metadataCollection, page, string.Join(" - ", title, page.Title), titleFormat);
            }
        }
        static void ConfigurePage(IDocumentMetadataCollection metadataCollection, DemoPageBase page, string title, string titleFormat) {
            if(page.Url != null && !page.IsMaintenanceMode) {
                var pageUrl = page.Url == "./" ? "" : page.Url;
                metadataCollection.AddPage(pageUrl)
                    .OpenGraph("url", page.OG_Url)
                    .OpenGraph("type", page.OG_Type)
                    .OpenGraph("title", page.OG_Title)
                    .OpenGraph("description", page.OG_Description)
                    .OpenGraph("image", page.OG_Image)
                    .Title(string.Format(titleFormat, title))
                    .Meta("description", page.Description)
                    .Meta("keywords", page.Keywords);
            }
        }
        // Search
        public List<DemoSearchResult> DoSearch(string request) {
            return Search.DoSearch(request);
        }
    }
}
