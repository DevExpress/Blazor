using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata {

    sealed class MetadataMarkupStaticRenderComponent : ComponentBase, IObserver<Renderer>, IDisposable {
        static readonly MarkupString TabInsideHeadElement = new MarkupString(Environment.NewLine + new string(' ', 4));

        readonly Queue<Renderer> _renderers = new Queue<Renderer>();
        IDisposable _unsubscribe;

        [Inject] public IObservable<Renderer> Metadata { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized() {
            base.OnInitialized();
            _unsubscribe = Metadata.Subscribe(this);
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            int seq = 0;
            while (_renderers.TryDequeue(out Renderer renderer)) {
                builder.AddContent(seq + 0, TabInsideHeadElement);
                seq = renderer.Render(builder, seq + 1, NavigationManager);
            }
            builder.OpenElement(seq + 2, "meta");
            builder.AddAttribute(seq + 3, "data-dxmetadatamanager", true);
            builder.CloseElement();
        }

        void IDisposable.Dispose() {
            using (_unsubscribe) _unsubscribe = null;
            _renderers.Clear();
        }


        void IObserver<Renderer>.OnCompleted() { }
        void IObserver<Renderer>.OnError(Exception error) { }
        void IObserver<Renderer>.OnNext(Renderer value) => _renderers.Enqueue(value);
    }
}
