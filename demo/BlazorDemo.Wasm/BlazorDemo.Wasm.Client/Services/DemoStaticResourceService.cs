using System;

namespace BlazorDemo.Services {
    public class DemoStaticResourceService : IDemoStaticResourceService {
        public string GetUrlWithVersion(string url) {
            return url;
        }
    }
}
