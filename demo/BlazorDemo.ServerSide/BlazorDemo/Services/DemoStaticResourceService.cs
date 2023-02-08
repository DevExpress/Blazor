using System;

namespace BlazorDemo.Services {
    public interface IDemoStaticResourceService {
        string GetUrlWithVersion(string url);
    }
}
