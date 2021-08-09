using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDemo.Shared {
    public class DynamicStylesheetLink : ComponentBase {
        string _lastRenderedUrl;
        bool _isLoading;
        LinkRenderingState _primaryLinkRenderingState = LinkRenderingState.Used;
        LinkRenderingState _secondaryLinkRenderingState = LinkRenderingState.Removed;

        [Parameter]
        public string Url { get; set; }

        [Parameter]
        public EventCallback OnLoad { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            if(Url != _lastRenderedUrl && !_isLoading) {
                UpdateLinkRenderingState(ref _primaryLinkRenderingState);
                UpdateLinkRenderingState(ref _secondaryLinkRenderingState);
                _isLoading = true;
            }
            RenderLink(builder, 0, _primaryLinkRenderingState);
            RenderLink(builder, 100, _secondaryLinkRenderingState);
        }

        void RenderLink(RenderTreeBuilder builder, int sequenceIndex, LinkRenderingState state) {
            if(state == LinkRenderingState.Removed) {
                return;
            }
            builder.OpenElement(sequenceIndex, "link");
            builder.AddAttribute(sequenceIndex + 1, "rel", "stylesheet");
            builder.AddAttribute(sequenceIndex + 2, "href", state != LinkRenderingState.Loading ? _lastRenderedUrl : Url);
            if(state == LinkRenderingState.Loading) {
                builder.AddAttribute(sequenceIndex + 3, "onload", EventCallback.Factory.Create(this, Link_LoadAsync));
            }
            builder.CloseElement();
        }

        void UpdateLinkRenderingState(ref LinkRenderingState state) {
            state = state switch {
                LinkRenderingState.Removed => LinkRenderingState.Loading,
                LinkRenderingState.Used => LinkRenderingState.Obsolete,
                LinkRenderingState.Obsolete => LinkRenderingState.Removed,
                LinkRenderingState.Loading => LinkRenderingState.Used,
                _ => state
            };
        }

        async Task Link_LoadAsync() {
            UpdateLinkRenderingState(ref _primaryLinkRenderingState);
            UpdateLinkRenderingState(ref _secondaryLinkRenderingState);
            _lastRenderedUrl = Url;
            _isLoading = false;
            await OnLoad.InvokeAsync();
        }

        enum LinkRenderingState {
            Used,
            Obsolete,
            Loading,
            Removed
        }
    }
}
