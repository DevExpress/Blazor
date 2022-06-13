using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDemo.Shared {
    public class DynamicStylesheetCompositeLink : ComponentBase {

        [Parameter]
        [EditorRequired]
        public IReadOnlyList<string> Urls { get; set; }

        [Parameter]
        public EventCallback OnLinksLoaded { get; set; }

        List<DynamicStylesheetLink> _links = new List<DynamicStylesheetLink>();
        
        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            if(!_links.Select(x => x.LoadedUrl).SequenceEqual(Urls)) {
                while(_links.Count < Urls.Count) {
                    _links.Add(new DynamicStylesheetLink { OnLoad = Link_LoadedAsync });
                }
                for(int i = 0; i < Urls.Count; ++i) {
                    _links[i].Url = Urls[i];
                }
            }

            for(int i = 0; i < _links.Count; ++i) {
                _links[i].BuildRenderTree(builder, i * DynamicStylesheetLink.MaxAttributesCount * 2);
            }
        }

        async Task Link_LoadedAsync() {
            if(_links.Any(x => !x.Loaded))
                return;
            
            foreach(var link in _links)
                link.OnLoadComplete();
            await OnLinksLoaded.InvokeAsync();
        }
        

        class DynamicStylesheetLink {

            public const int MaxAttributesCount = 100;
            
            public string Url { get; set; }
            public Func<Task> OnLoad { get; init; }
            public bool Loaded { get; private set; } = true;
            public string LoadedUrl { get; private set; }

            LinkRenderingState _primaryLinkRenderingState = LinkRenderingState.Used;
            LinkRenderingState _secondaryLinkRenderingState = LinkRenderingState.Removed;

            string LoadingUrl { get; set; }
            object _primaryLinkKey = new object();
            object _secondaryLinkKey = new object();
            
            private bool IsLoading { get; set; } = false;

            public void BuildRenderTree(RenderTreeBuilder builder, int sequenceIndex) {
                if(Url != LoadedUrl) {
                    if(IsLoading) {
                        if(Url != LoadingUrl) {
                            if(_primaryLinkRenderingState == LinkRenderingState.Loading)
                                _primaryLinkKey = new object();
                            if(_secondaryLinkRenderingState == LinkRenderingState.Loading)
                                _secondaryLinkKey = new object();
                            LoadingUrl = Url;
                        }
                    }
                    StartLoading(ref _primaryLinkRenderingState);
                    StartLoading(ref _secondaryLinkRenderingState);
                    LoadingUrl = Url;
                    IsLoading = true;
                    Loaded = false;
                    if(string.IsNullOrEmpty(Url)) {
                        CancelLoading(ref _primaryLinkRenderingState);
                        CancelLoading(ref _secondaryLinkRenderingState);
                        Loaded = true;
                        IsLoading = false;
                    }
                }
                RenderLink(builder, sequenceIndex + 0, _primaryLinkRenderingState, _primaryLinkKey);
                RenderLink(builder, sequenceIndex + MaxAttributesCount, _secondaryLinkRenderingState, _secondaryLinkKey);
            }

            public void OnLoadComplete() {
                CompleteLoading(ref _primaryLinkRenderingState);
                CompleteLoading(ref _secondaryLinkRenderingState);
                LoadingUrl = null;
                IsLoading = false;
                LoadedUrl = Url;
            }
            
            void RenderLink(RenderTreeBuilder builder, int sequenceIndex, LinkRenderingState state, object key) {
                if(state == LinkRenderingState.Removed) {
                    return;
                }
            
                var href = state != LinkRenderingState.Loading ? LoadedUrl : LoadingUrl;
                if(string.IsNullOrEmpty(href)) {
                    return;
                }
            
                builder.OpenElement(sequenceIndex, "link");
                builder.SetKey(key);
                builder.AddAttribute(sequenceIndex + 1, "rel", "stylesheet");
                builder.AddAttribute(sequenceIndex + 2, "href", href);
                if(state == LinkRenderingState.Loading) {
                    builder.AddAttribute(sequenceIndex + 3, "onload", EventCallback.Factory.Create(this, Link_LoadAsync));
                }
                builder.CloseElement();
            }

            void StartLoading(ref LinkRenderingState state) {
                state = state switch {
                    LinkRenderingState.Removed => LinkRenderingState.Loading,
                    LinkRenderingState.Used => LinkRenderingState.Obsolete,
                    _ => state
                };
            }

            void CancelLoading(ref LinkRenderingState state) {
                state = state switch {
                    LinkRenderingState.Obsolete => LinkRenderingState.Used,
                    LinkRenderingState.Loading => LinkRenderingState.Removed,
                    _ => state
                };
            }

            void CompleteLoading(ref LinkRenderingState state) {
                state = state switch {
                    LinkRenderingState.Loading => LinkRenderingState.Used,
                    LinkRenderingState.Obsolete => LinkRenderingState.Removed,
                    _ => state
                };
            }

            async Task Link_LoadAsync() {
                Loaded = true;
                await OnLoad.Invoke();
            }
        }
        
        enum LinkRenderingState {
            Used,
            Obsolete,
            Loading,
            Removed
        }
    }
}
