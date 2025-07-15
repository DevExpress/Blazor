using System.Collections.Generic;
using BlazorDemo.Configuration;
using DevExpress.Blazor;

namespace BlazorDemo.Services {
    struct BootstrapThemeNames {
        public const string Cerulean = "cerulean";
        public const string Default = "default";
        public const string DefaultDark = "default-dark";
        public const string Flatly = "flatly";
        public const string Journal = "journal";
        public const string Lumen = "lumen";
    }

    public static class BlazorDemoThemes {
        public const string HighlightJsAndroidTheme = "https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/styles/androidstudio.min.css";
        public const string HighlightJsDefaultTheme = "https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.6/styles/default.min.css";
        public const string DxCommonStylesPath = "_content/BlazorDemo/css/dx/common.css";
        public const string FluentCommonStylesPath = "_content/BlazorDemo/css/fluent/common.css";

        public static string GetBootstrapThemePath(string themeName) {
            return $"_content/BlazorDemo/css/switcher-resources/themes/{themeName}/bootstrap.min.css";
        }

        public static string GetBootstrapFluentThemePath(string themeName) {
            return $"_content/BlazorDemo/css/switcher-resources/themes/fluent/{themeName}.bs5.min.css";
        }

        public static void AddDefaultDxTheme(ThemeProperties properties) {
            properties.AddFilePaths(
                DxCommonStylesPath,
                HighlightJsDefaultTheme
            );
        }

        public static void AddAndroidDxTheme(ThemeProperties properties) {
            properties.AddFilePaths(
                DxCommonStylesPath,
                HighlightJsAndroidTheme
            );
        }

        public static readonly ITheme BlazingBerry = Themes.BlazingBerry.Clone(AddDefaultDxTheme);
        public static readonly ITheme BlazingDark = Themes.BlazingDark.Clone(AddAndroidDxTheme);
        public static readonly ITheme Purple = Themes.Purple.Clone(AddDefaultDxTheme);
        public static readonly ITheme OfficeWhite = Themes.OfficeWhite.Clone(AddDefaultDxTheme);

        public static readonly ITheme Cerulean = Themes.BootstrapExternal.Clone(p => {
            p.Name = BootstrapThemeNames.Cerulean;
            p.AddFilePaths(GetBootstrapThemePath(BootstrapThemeNames.Cerulean));
            AddDefaultDxTheme(p);
        });

        public static readonly ITheme BootstrapDefault = Themes.BootstrapExternal.Clone(p => {
            p.Name = BootstrapThemeNames.Default;
            p.AddFilePaths(GetBootstrapThemePath(BootstrapThemeNames.Default));
            AddDefaultDxTheme(p);
        });

        public static readonly ITheme BootstrapDefaultDark = Themes.BootstrapExternal.Clone(p => {
            p.Name = BootstrapThemeNames.DefaultDark;
            p.AddFilePaths(GetBootstrapThemePath(BootstrapThemeNames.Default));
            AddAndroidDxTheme(p);
        });

        public static readonly ITheme BootstrapFlatly = Themes.BootstrapExternal.Clone(p => {
            p.Name = BootstrapThemeNames.Flatly;
            p.AddFilePaths(GetBootstrapThemePath(BootstrapThemeNames.Flatly));
            AddDefaultDxTheme(p);
        });

        public static readonly ITheme BootstrapJournal = Themes.BootstrapExternal.Clone(p => {
            p.Name = BootstrapThemeNames.Journal;
            p.AddFilePaths(GetBootstrapThemePath(BootstrapThemeNames.Journal));
            AddDefaultDxTheme(p);
        });

        public static readonly ITheme BootstrapLumen = Themes.BootstrapExternal.Clone(p => {
            p.Name = BootstrapThemeNames.Lumen;
            p.AddFilePaths(GetBootstrapThemePath(BootstrapThemeNames.Lumen));
            AddDefaultDxTheme(p);
        });
    }

    public static class DemoThemes {
        public static readonly DemoTheme BlazingBerry =
            new DemoTheme(BlazorDemoThemes.BlazingBerry, "blazing-berry", "Blazing Berry", "#5c2d91");

        public static readonly DemoTheme BlazingDark =
            new DemoTheme(BlazorDemoThemes.BlazingDark, "blazing-dark", "Blazing Dark", "#46444a");

        public static readonly DemoTheme Purple = new DemoTheme(BlazorDemoThemes.Purple, "purple", "Purple", "#7989ff");

        public static readonly DemoTheme OfficeWhite =
            new DemoTheme(BlazorDemoThemes.OfficeWhite, "office-white", "Office White", "#fe7109");

        public static readonly DemoTheme FluentBlue = new DemoTheme("fluent-blue", "Blue", "#0f6cbd", ThemeFluentAccentColor.Blue);
        public static readonly DemoTheme FluentCoolBlue = new DemoTheme("fluent-cool-blue", "Cool Blue", "#2d7d9a", ThemeFluentAccentColor.CoolBlue);
        public static readonly DemoTheme FluentDesert = new DemoTheme("fluent-desert", "Desert", "#847545", ThemeFluentAccentColor.Desert);
        public static readonly DemoTheme FluentMint = new DemoTheme("fluent-mint", "Mint", "#018574", ThemeFluentAccentColor.Mint);
        public static readonly DemoTheme FluentMoss = new DemoTheme("fluent-moss", "Moss", "#486860", ThemeFluentAccentColor.Moss);
        public static readonly DemoTheme FluentOrchid = new DemoTheme("fluent-orchid", "Orchid", "#c239b3", ThemeFluentAccentColor.Orchid);
        public static readonly DemoTheme FluentPurple = new DemoTheme("fluent-purple", "Purple", "#5b5fc7", ThemeFluentAccentColor.Purple);
        public static readonly DemoTheme FluentRose = new DemoTheme("fluent-rose", "Rose", "#ea005e", ThemeFluentAccentColor.Rose);
        public static readonly DemoTheme FluentRust = new DemoTheme("fluent-rust", "Rust", "#da3b01", ThemeFluentAccentColor.Rust);
        public static readonly DemoTheme FluentSteel = new DemoTheme("fluent-steel", "Steel", "#68768a", ThemeFluentAccentColor.Steel);
        public static readonly DemoTheme FluentStorm = new DemoTheme("fluent-storm", "Storm", "#4c4a48", ThemeFluentAccentColor.Storm);

        public static readonly DemoTheme BootstrapDefault =
            new DemoTheme(BlazorDemoThemes.BootstrapDefault, "default", "Default", "#027BFF") { IsBootstrapNative = true };

        public static readonly DemoTheme BootstrapDefaultDark =
            new DemoTheme(BlazorDemoThemes.BootstrapDefaultDark, "default-dark", "Default Dark", "#212529") { BootstrapThemeMode = "dark", IsBootstrapNative = true };

        public static readonly DemoTheme BootstrapCerulean =
            new DemoTheme(BlazorDemoThemes.Cerulean, "cerulean", "Cerulean", "#2EA4E7") { IsBootstrapNative = true };

        public static readonly DemoTheme BootstrapFlatly =
            new DemoTheme(BlazorDemoThemes.BootstrapFlatly, "flatly", "Flatly", "#DBE4EC") { IsBootstrapNative = true };

        public static readonly DemoTheme BootstrapJournal =
            new DemoTheme(BlazorDemoThemes.BootstrapJournal, "journal", "Journal", "#EB6864") { IsBootstrapNative = true };

        public static readonly DemoTheme BootstrapLumen =
            new DemoTheme(BlazorDemoThemes.BootstrapLumen, "lumen", "Lumen", "#158CBA") { IsBootstrapNative = true };
    }
}
