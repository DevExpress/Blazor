using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DevExpress.Drawing;

namespace BlazorDemo.Services {
    public static class ReportingFontLoader {
        readonly static DXFontRepository dXFontRepository = DXFontRepository.Instance;
        readonly static Dictionary<string, bool> loadedFonts = new();

#pragma warning disable DX0006
        public static async Task LoadFonts(HttpClient httpClient, string fontName) {
            if(!loadedFonts.ContainsKey(fontName)) {
                var boldName = fontName + "bd";
                await LoadFont(httpClient, fontName);
                await LoadFont(httpClient, boldName);
                loadedFonts.Add(fontName, true);
            }
        }
#pragma warning restore DX0006

#pragma warning disable DX0006
        async static Task LoadFont(HttpClient httpClient, string fontName) {
            var fontBytes = await httpClient.GetByteArrayAsync($"_content/BlazorDemo/fonts/{fontName}.ttf");
            dXFontRepository.AddFont(fontBytes);
        }
#pragma warning restore DX0006
    }
}
