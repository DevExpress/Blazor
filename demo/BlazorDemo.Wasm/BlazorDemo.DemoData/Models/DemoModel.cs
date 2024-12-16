using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorDemo.DemoData {
    public class DemoModel {
        public string AssemblyName { get; set; }
        public string TitleFormat { get; set; }

        public DemoGroup[] Groups { get; set; }
        public DemoProductInfo[] Products { get; set; }
        public DemoSearchModel Search { get; set; }

        [JsonIgnore]
        public Dictionary<string, string> Redirects { get; private set; } = new();

        [JsonIgnore]
        public bool IsBlazorServer { get; private set; }

        public static DemoModel Create(bool isBlazorServer) {
            var jsonContent = DemoUtils.GetFileContent(typeof(DemoModel), "BlazorDemo.DemoData.demo-metadata.json");
            return Create(isBlazorServer, jsonContent);
        }
        public static DemoModel Create(bool isBlazorServer, string jsonContent) {
            var model = JsonSerializer.Deserialize<DemoModel>(jsonContent);
            model.IsBlazorServer = isBlazorServer;
            model.Prepare();
            return model;
        }
        void Prepare() {
            Products = PrepareList(Products);
            Redirects = new Dictionary<string, string>();
            foreach(var group in Groups) {
                group.Pages = PrepareList(group.Pages);
                PrepareRecursive(group.Pages, null, group);
            }
            Groups = PrepareList(Groups);
        }
        void PrepareRecursive(IEnumerable<DemoItem> childItems, DemoPage parent, DemoGroup group) {
            foreach(var item in childItems) {
                item.ParentPage = parent;
                item.Group = group;
                if(item is DemoPage page) {
                    page.Pages = PrepareList(page.Pages);
                    page.PageSections = PrepareList(page.PageSections);
                    PrepareRecursive(page.GetChildItems(), page, group);
                }
                if(item.RedirectFrom?.Length > 0) {
                    foreach(var redirect in item.RedirectFrom)
                        Redirects.Add(redirect.ToLower(), item.GetUrl());
                }
                DemoItemById[item.UniqueId] = item;
            }
        }
        T[] PrepareList<T>(T[] list) {
            if(list == null)
                return Array.Empty<T>();
            IEnumerable<T> result = list;
            result = result
               .Where(i => i switch {
                   DemoProductInfo info => !(IsBlazorServer ? info.IsClientSideOnly : info.IsServerSideOnly),
                   DemoItem item => !(IsBlazorServer ? item.IsClientSideOnly : item.IsServerSideOnly),
                   DemoGroup group => group.Pages.Length > 0,
                   _ => throw new NotSupportedException()
               });
            return result
                .OrderBy(i => i is DemoPage page ? page.IsMaintenanceMode : false)
                .ToArray();
        }

        public DemoPage GetDemoPageByUrl(string pageUrl) {
            pageUrl = pageUrl.Trim('/').Split('#')[0];
            return FindRecursive(Groups.SelectMany(g => g.Pages), item => item is DemoPage page && string.Equals(page.Url, pageUrl, StringComparison.OrdinalIgnoreCase)) as DemoPage;
        }

        public DemoItem FindDemoItemRecursively(Func<DemoItem, bool> predicate) {
            return FindRecursive(Groups.SelectMany(g => g.Pages), predicate);
        }

        DemoItem FindRecursive(IEnumerable<DemoItem> pages, Func<DemoItem, bool> predicate) {
            if(pages == null)
                return null;
            foreach(var page in pages) {
                if(predicate(page)) return page;
                var nestedResult = FindRecursive(page.GetChildItems(), predicate);
                if(nestedResult != null)
                    return nestedResult;
            }
            return null;
        }

        protected Dictionary<string, DemoItem> DemoItemById { get; } = new();

        public DemoItem GetDemoItem(string id) {
            if(DemoItemById.TryGetValue(id, out var res))
                return res;
            return null;
        }
        public string GetDemoItemDescriptionResourcePath(DemoItem item, string rootFolder) {
            return GetDemoItemResourcePath(item, rootFolder, s => {
                var folder = item.GetDescriptionFilesFolder();
                return !string.IsNullOrEmpty(folder) ? folder : s + ".Descriptions";
            }, ".md");
        }
        public string GetDemoItemRazorResourcePath(DemoItem item, string rootFolder) {
            return GetDemoItemResourcePath(item, rootFolder, s => {
                var folder = item.GetRazorFilesFolder();
                return !string.IsNullOrEmpty(folder) ? folder : s;
            }, ".razor");
        }
        string GetDemoItemResourcePath(DemoItem item, string rootFolder, Func<string, string> getFolder, string extension) {
            var itemIds = item.UniqueId.Split('-').ToList();
            var partCount = itemIds.Count;
            if(item is DemoPageSection || partCount > 2)
                partCount = Math.Max(partCount - 1, 1);
            List<string> pathParts = new List<string>();
            if(!string.IsNullOrEmpty(rootFolder))
                pathParts.Add(rootFolder);
            pathParts.Add(getFolder(string.Join(".", itemIds.Take(partCount))));
            pathParts.Add(string.Join("-", itemIds) + extension);
            return string.Join(".", pathParts);
        }
    }
}
