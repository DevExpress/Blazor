using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress.Blazor.AnchorUtils {
    public class AnchorUtilsComponent: ComponentBase, IDisposable {
        [Inject] public IUriHelper UriHelper { get; set; }
        [Inject] public IJSRuntime JSRuntime { get; set; }
        [Inject] public IComponentContext ComponentContext { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        string Anchor { get; set; }

        bool ForceScroll { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceScroll = true;

            UriHelper.OnLocationChanged += OnLocationChanged;
        }

        protected override Task OnAfterRenderAsync()
        {
            ScrollToAnchor(Anchor);

            ForceScroll = false; 

            return base.OnAfterRenderAsync();
        }

        void OnLocationChanged(object sender, LocationChangedEventArgs args)
        {
            var anchor = UriHelper.ToAbsoluteUri(args.Location).Fragment;
            if (!ScrollToAnchor(anchor)) 
                Anchor = anchor;
        }

        bool ScrollToAnchor(string anchor)
        {
            if (ComponentContext.IsConnected && (!string.IsNullOrEmpty(anchor) || ForceScroll))
            {
                JSRuntime.InvokeAsync<string>("scrollToAnchor", anchor);
                return true;
            }

            return false;
        }

        void IDisposable.Dispose()
        {
            UriHelper.OnLocationChanged -= OnLocationChanged;
        }
    }
}
