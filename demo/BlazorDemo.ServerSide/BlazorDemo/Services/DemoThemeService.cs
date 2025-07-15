using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using DevExpress.Blazor;

namespace BlazorDemo.Services {
    public interface IDemoThemeChangeRequestDispatcher {
        void RequestThemeChange(DemoTheme theme);
    }

    public interface IDemoThemeLoadNotifier {
        Task NotifyThemeLoadedAsync(DemoTheme theme);
    }

    public class ThemeState {
        public ThemeMode? Mode { get; set; } = ThemeMode.Light;
        public string CustomAccentColor { get; set; } = null;

        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
    }

    public class DemoThemeService {
        private DemoTheme _activeTheme;
        private ThemeState _themeState;
#if SERVER_BLAZOR
        public const string ThemeCookieKey = "DXBZCurrentTheme";
#else
        public const string ThemeCookieKey = "DXBZCurrentWasmTheme";
#endif
        public static readonly string ThemeStateCookieKey = $"{ThemeCookieKey}_Opts";
        public IDemoThemeChangeRequestDispatcher ThemeChangeRequestDispatcher { get; set; }

        public IDemoThemeLoadNotifier ThemeLoadNotifier { get; set; }

        public DemoThemeService() {
            ResourcesReadyState = new ConcurrentDictionary<string, TaskCompletionSource<bool>>();
        }

        public ConcurrentDictionary<string, TaskCompletionSource<bool>> ResourcesReadyState { get; }
        public DemoTheme ActiveTheme => _activeTheme;
        public ThemeState ThemeState => _themeState;
        public DemoTheme DefaultTheme => DemoThemes.FluentBlue;

        public void SetActiveThemeByName(string themeName) {
            var theme = FindThemeByName(themeName);
            if(theme != null)
                _activeTheme = theme;
            else
                _activeTheme = DefaultTheme;
        }

        private DemoTheme FindThemeByName(string themeName) {
            return Themes.SingleOrDefault(theme => theme.Name == themeName);
        }

        public void SetThemeState(ThemeState themeState) {
            _themeState = themeState;
        }

        public List<DemoTheme> FluentThemes = [
            DemoThemes.FluentBlue,
            DemoThemes.FluentCoolBlue,
            DemoThemes.FluentDesert,
            DemoThemes.FluentMint,
            DemoThemes.FluentMoss,
            DemoThemes.FluentOrchid,
            DemoThemes.FluentPurple,
            DemoThemes.FluentRose,
            DemoThemes.FluentRust,
            DemoThemes.FluentSteel,
            DemoThemes.FluentStorm,
        ];

        public DemoTheme CustomFluentDemoTheme = new DemoTheme("CustomFluent", String.Empty) { IsFluent = true };

        public List<DemoTheme> ClassicThemes = [
            DemoThemes.BlazingBerry,
            DemoThemes.BlazingDark,
            DemoThemes.Purple,
            DemoThemes.OfficeWhite
        ];


        public List<DemoTheme> BootstrapThemes = [
            DemoThemes.BootstrapDefault,
            DemoThemes.BootstrapDefaultDark,
            DemoThemes.BootstrapCerulean,
            DemoThemes.BootstrapFlatly,
            DemoThemes.BootstrapJournal,
            DemoThemes.BootstrapLumen
        ];

        public List<DemoTheme> Themes =>
            FluentThemes
                .Concat(ClassicThemes)
                .Concat(BootstrapThemes)
                .Concat([CustomFluentDemoTheme])
                .ToList();
    }
}
