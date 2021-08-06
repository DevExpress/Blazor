using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BlazorDemo.Shared;
using BlazorDemo.Shared.ThemeSwitcher;
using BlazorDemo.Configuration;

namespace BlazorDemo.Services {
    public interface IDemoThemesConfigurationCookieAccessor {
        string GetCookie(string name);
    }

    public interface IDemoThemeChangeRequestDispatcher {
        void RequestThemeChange(DemoTheme theme);
    }

    public interface IDemoThemeLoadNotifier {
        Task NotifyThemeLoadedAsync(DemoTheme theme);
    }

    public class DemoThemeService {
        private DemoTheme _activeTheme;
#if SERVER_BLAZOR
        const string ThemeCookieKey = "DXBS4CurrentTheme";
#else
        const string ThemeCookieKey = "DXBS4CurrentWasmTheme";
#endif
        const string DefaultThemeName = "blazing-berry";
        readonly Dictionary<string, string> HighlightJSThemes = new Dictionary<string, string>() {
            { DefaultThemeName, "default" },
            { "cyborg", "androidstudio" },
            { "darkly", "androidstudio" },
            { "slate", "atom-one-dark" }
        };

        public IDemoThemeChangeRequestDispatcher ThemeChangeRequestDispatcher { get; set; }

        public IDemoThemeLoadNotifier ThemeLoadNotifier { get; set; }

        public DemoThemeService(IDemoThemesConfigurationCookieAccessor cookieAccessor) {
            ResourcesReadyState = new ConcurrentDictionary<string, TaskCompletionSource<bool>>();
            ThemeSets = CreateSets(this);
            CookieAccessor = cookieAccessor;
        }

        protected IDemoThemesConfigurationCookieAccessor CookieAccessor { get; }

        public ConcurrentDictionary<string, TaskCompletionSource<bool>> ResourcesReadyState { get; }
        public List<DemoThemeSet> ThemeSets { get; }
        public DemoTheme ActiveTheme {
            get {
                if(_activeTheme == null) {
                    var themeName = CookieAccessor.GetCookie(ThemeCookieKey);
                    SetActiveThemeByName(themeName);
                }
                return _activeTheme;
            }
        }
        public DemoTheme DefaultTheme {
            get { return ThemeSets.SelectMany(ts => ts.Themes).Where(t => t.Name == DefaultThemeName).FirstOrDefault(); }
        }

        public string GetThemeCssUrl(DemoTheme theme) {
            return $"_content/BlazorDemo/css/switcher-resources/themes/{theme.Name}/bootstrap.min.css";
        }
        public string GetActiveThemeCssUrl() {
            return GetThemeCssUrl(ActiveTheme);
        }
        public string GetHighlightJSThemeCssUrl(DemoTheme theme) {
            var highlightjsTheme = HighlightJSThemes[DefaultThemeName];
            if(HighlightJSThemes.ContainsKey(theme.Name))
                highlightjsTheme = HighlightJSThemes[theme.Name];
            return $"//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/styles/{highlightjsTheme}.min.css";
        }
        public string GetActiveHighlightJSThemeCssUrl() {
            return GetHighlightJSThemeCssUrl(ActiveTheme);
        }

        public void SetActiveThemeByName(string themeName) {
            var theme = FindThemeByName(themeName);
            if(theme != null)
                _activeTheme = theme;
            else
                _activeTheme = DefaultTheme;
        }
        private DemoTheme FindThemeByName(string themeName) {
            var themes = ThemeSets.SelectMany(ts => ts.Themes);
            foreach(var theme in themes) {
                if(theme.Name == themeName)
                    return theme;
            }
            return null;
        }

        private static List<DemoThemeSet> CreateSets(DemoThemeService config) {
            return new List<DemoThemeSet>() {
                new DemoThemeSet("Color Themes",  "default"),
                new DemoThemeSet("DevExpress Themes", "blazing-berry", "purple", "office-white"),
                new DemoThemeSet("Bootswatch Themes", "cerulean", "cosmo", "cyborg", "darkly", "flatly", "journal", "litera", "lumen", "lux", "materia", "minty", "pulse",
                    "sandstone", "simplex", "sketchy", "slate", "solar", "spacelab", "superhero", "united", "yeti")
            };
        }
    }
}
