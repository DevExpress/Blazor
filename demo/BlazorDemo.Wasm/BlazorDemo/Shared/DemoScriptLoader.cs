using System;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using BlazorDemo.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

namespace BlazorDemo.Shared {
    public class DemoScriptLoader : ComponentBase, IDisposable {
        [Parameter] public string Src { get; set; }
        [Parameter] public string Code { get; set; }
        public Task Loaded => _scriptTcs.Task;
        [Inject] DemoThemeService Themes { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }
        [Inject] IDemoVersion DemoVersion { get; set; }

        bool _canLoadScript, _jsAttached, _isInlinedMethod;
        TaskCompletionSource<bool> _scriptTcs;
        public async ValueTask InvokeVoidAsync(string identifier, params object[] args) {
            if(_scriptTcs != null) {
                if(!_scriptTcs.Task.IsCompleted)
                    await _scriptTcs.Task;
                await JSRuntime.InvokeVoidAsync(identifier, args);
            }
        }

        protected override void OnInitialized() {
            _isInlinedMethod = string.IsNullOrEmpty(Src) && !string.IsNullOrEmpty(Code);
            _scriptTcs = Themes.ResourcesReadyState.GetOrAdd(_isInlinedMethod ? Code : Src, CreateScriptReadyTcs);
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            if(_jsAttached && _canLoadScript) {
                _canLoadScript = false;
                builder.OpenElement(0, "script");
                builder.AddAttribute(1, "type", "text/javascript");
                if(!_isInlinedMethod) {
                    var clientSrcValue = Src;
                    if(!clientSrcValue.Contains('?'))
                        clientSrcValue += $"?version={DemoVersion.Version}";
                    builder.AddAttribute(2, "src", clientSrcValue);
                    builder.AddAttribute(3, "async", true);
                    builder.AddAttribute(4, "onload", EventCallback.Factory.Create(this, OnScriptLoaded));
                } else
                    builder.AddContent(5, Code);
                builder.CloseElement();
            }
        }

        protected override void OnAfterRender(bool firstRender) {
            if(firstRender && _canLoadScript) {
                _jsAttached = true;
                StateHasChanged();
            } else if(!firstRender && _isInlinedMethod)
                OnScriptLoaded();
        }

        TaskCompletionSource<bool> CreateScriptReadyTcs(string _) {
            _canLoadScript = true;
            return new TaskCompletionSource<bool>();
        }

        void OnScriptLoaded() {
            _scriptTcs?.TrySetResult(true);
        }

        void IDisposable.Dispose() {
            _scriptTcs = null;
        }
    }
}
