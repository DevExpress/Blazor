using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace DevExpress.Blazor.DocumentMetadata {

    sealed class MetadataRendererComparer : IEqualityComparer<Renderer> {
        public bool Equals(Renderer x, Renderer y) => x.Equals(y);
        public int GetHashCode(Renderer obj) => obj.GetHashCode();

        public static readonly IEqualityComparer<Renderer> Default = new MetadataRendererComparer();

        MetadataRendererComparer() { }
    }

    static class NavigationManagerExtensons {
        public static string GetCurrentPageName(this NavigationManager navigationManager) => navigationManager.GetPageNameByLocation(navigationManager.Uri);
        public static string GetPageNameByLocation(this NavigationManager navigationManager, string location) {
            var uriFragment = navigationManager.ToAbsoluteUri(location).Fragment;
            if (!string.IsNullOrEmpty(uriFragment))
                location = location.Replace(uriFragment, "");
            return navigationManager.ToBaseRelativePath(location);
        }
        public static string ResolveUrl(this NavigationManager navigationManager, string url) {
            if (url.StartsWith("~/")) {
                string baseUrl = navigationManager.BaseUri;
                string absoluteUrl = baseUrl + url.Substring(2);
                url = navigationManager.ToBaseRelativePath(absoluteUrl);
                url = navigationManager.ToAbsoluteUri(url).PathAndQuery;
            }
            return url;
        }
    }
}
