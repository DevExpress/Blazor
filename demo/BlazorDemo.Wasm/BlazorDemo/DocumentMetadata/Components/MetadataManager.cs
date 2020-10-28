using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DevExpress.Blazor.DocumentMetadata {

    [RequireJavascriptApi("dx-head-manager.js")]
    class MetadataManagerComponent : ComponentBase, IObserver<Renderer>, IDisposable {

        bool _initialized, _disposed;
        readonly ConcurrentQueue<Renderer> _renderers = new ConcurrentQueue<Renderer>();
        readonly CancellationTokenSource _cancellation;
        readonly CancellationToken _cancellationToken;
        DotNetObjectReference<MetadataManagerComponent> _dotnetRef;
        protected ElementReference ElementReference { get; set; }
        [Inject] public IObservable<Renderer> Metadata { get; set; }
        [Inject] public IJSRuntime JSRuntime { get; set; }

        public MetadataManagerComponent() {
            _cancellation = new CancellationTokenSource();
            _cancellationToken = _cancellation.Token;
        }

        protected override bool ShouldRender() => false;
        protected override async Task OnAfterRenderAsync(bool firstRender) {
            if (firstRender && _dotnetRef == null) {
                _cancellationToken.ThrowIfCancellationRequested();
                _dotnetRef = DotNetObjectReference.Create(this);
                try {
                    await JSRuntime.InvokeAsync<List<Renderer>>(JSInitializeMethod, _cancellationToken,
                        _dotnetRef, ElementReference);
                } catch { }
                _cancellationToken.Register(Metadata.Subscribe(this).Dispose);
            }
        }

        protected virtual string JSInitializeMethod => "_dxInitDocumentEnvironment";

        void RequireMetadataSync() => InvokeAsync(SyncMetadata);

        async Task SyncMetadata() {
            _cancellationToken.ThrowIfCancellationRequested();

            if (!_renderers.IsEmpty) {
                await JSRuntime.InvokeVoidAsync("_bulkUpdateMetadata", _cancellationToken, _dotnetRef, _renderers);
                _renderers.Clear();
            }
        }

        public void Dispose() {
            if (!_disposed) {
                _disposed = true;
                _renderers.Clear();
                using (_cancellation) _cancellation.Cancel();
                using (_dotnetRef) _dotnetRef = null;
            }
        }


        void IObserver<Renderer>.OnNext(Renderer value) {
            _renderers.Enqueue(value);
            if (_initialized) RequireMetadataSync();
        }
        void IObserver<Renderer>.OnCompleted() {
            _initialized = true;
            RequireMetadataSync();
        }
        void IObserver<Renderer>.OnError(Exception error) { }

    }
}
