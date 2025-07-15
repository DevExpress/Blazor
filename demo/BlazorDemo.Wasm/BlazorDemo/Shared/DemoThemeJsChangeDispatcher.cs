using System;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using BlazorDemo.Services;
using DevExpress.Blazor;
using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemo.Shared;

public class DemoThemeJsChangeDispatcher : ComponentBase, IDemoThemeChangeRequestDispatcher, IAsyncDisposable {
    [Parameter] public string InitialThemeName { get; set; }
    [Parameter] public ThemeState InitialThemeState { get; set; }
    [Inject] private ISafeJSRuntime JsRuntime { get; set; }

    [Inject] private DemoThemeService Themes { get; set; }
    [Inject] protected IThemeChangeService ThemeChangeService { get; set; }

    [Inject] private IDemoStaticResourceService DemoStaticResourceService { get; set; }

    private DemoTheme _pendingTheme;
    private IJSObjectReference _module;

    protected override void OnInitialized() {
        base.OnInitialized();

        Themes.ThemeChangeRequestDispatcher = this;

        if(Themes.ActiveTheme == null)
            Themes.SetActiveThemeByName(InitialThemeName);

        if(Themes.ThemeState == null)
            Themes.SetThemeState(InitialThemeState);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender) {
        await base.OnAfterRenderAsync(firstRender);

        if(firstRender)
            _module = await JsRuntime.InvokeAsync<IJSObjectReference>("import",
                "./_content/BlazorDemo/lib/theme-controller.js");
    }

    public async void RequestThemeChange(DemoTheme theme) {
        if(_pendingTheme != null) return;

        _pendingTheme = theme;

        await ThemeChangeService.SetTheme(theme.ApplyStoredState(Themes.ThemeState));

        await _module.InvokeVoidAsync("ThemeController.switchBsThemeMode", theme.BootstrapThemeMode, DotNetObjectReference.Create(this));
    }

    [JSInvokable]
    public async Task ThemeLoadedAsync() {
        if(Themes.ThemeLoadNotifier != null) {
            await Themes.ThemeLoadNotifier.NotifyThemeLoadedAsync(_pendingTheme);
        }

        _pendingTheme = null;
    }

    public async ValueTask DisposeAsync() {
        try {
            if(_module != null)
                await _module.DisposeAsync();
        } catch(JSDisconnectedException) { }
    }
}
