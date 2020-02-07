using DevExpress.Blazor.Base;
using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorDemo.ClientSide.Shared {
    public class DxScrollViewBase : DxComponentBase {
        protected ElementReference InputElement;

        [Inject] IJSRuntime JsRuntime { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        public DxScrollViewBase() { }

        protected override Task InitClientSide(bool firstRender) {
            return JsRuntime.InvokeAsync<string>("ScrollViewInit", InputElement).AsTask();
        }
    }
}
