using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;

namespace DevExpress.Blazor.DocumentMetadata {

    sealed class DocumentMetadataSetup {
        readonly Action<IServiceProvider, IDocumentMetadataCollection> _initialize;

        internal DocumentMetadataSetup() : this(null) { }

        internal DocumentMetadataSetup(Action<IServiceProvider, IDocumentMetadataCollection> initialize) {
            _initialize = initialize;
        }
        internal void Initialize(IServiceProvider serviceProvider, IDocumentMetadataCollection registrator) {
            _initialize?.Invoke(serviceProvider, registrator);
        }
    }

    sealed class MetadataRendererSet : HashSet<Renderer> {
        internal MetadataRendererSet() : base(MetadataRendererComparer.Default) { }
    }

    sealed class MetadataCache : ConcurrentDictionary<string, ISet<Renderer>> {
        internal ISet<Renderer> GetPageRenderers(string pageName) {
            return GetOrAdd(GetFixedPageName(pageName), (_) => new MetadataRendererSet());
        }
        internal bool TryGetPageRenderers(string pageName, out ISet<Renderer> _) => TryGetValue(GetFixedPageName(pageName), out _);
        static string GetFixedPageName(string route) {
            if (route.Length == 0 || route[0] != '/')
                return route.Insert(0, "/");
            else
                return route;
        }
    }

    sealed class DocumentMetadataService : IDocumentMetadataCollection, IDocumentMetadataService, IDisposable {

        static readonly string
            DefaultMetadataCacheKey = $"default_{Guid.NewGuid()}",
            OverrideMetadataCacheKey = $"override_{Guid.NewGuid()}",
            RclBaseAssemblyName = typeof(ComponentBase).Assembly.GetName().Name;

        readonly MetadataCache _cache = new MetadataCache();

        public DocumentMetadataService(IServiceProvider serviceProvider, DocumentMetadataSetup setup) {
            foreach (var VARIABLE in AppDomain.CurrentDomain.GetAssemblies()
                .Where(IsAssemblyCanContainComponents)
                .SelectMany(ExtractSeoInfoFromAssembly)) {
                
                RegisterSeoInfo(VARIABLE);
            }
            setup.Initialize(serviceProvider, this);
        }

        public Action UpdateCompleted { get; set; }

        public void Update(Action<IDocumentMetadataBuilder> update) {
            update(AddPage(OverrideMetadataCacheKey));
            UpdateCompleted?.Invoke();
        }
        public IDocumentMetadataBuilder AddDefault() => AddPage(DefaultMetadataCacheKey);
        public IDocumentMetadataBuilder AddPage(string pageName) => new DocumentMetadataBuilder(pageName, _cache.GetPageRenderers(pageName));

        internal IEnumerable<Renderer> GetRenderers(string pageName) =>
            GetRenderers(_cache, DefaultMetadataCacheKey, pageName, OverrideMetadataCacheKey).
            Where(Enumerable.Any).
            Aggregate(MergeRenderers);

        IEnumerable<Renderer> MergeRenderers(
                IEnumerable<Renderer> prev,
                IEnumerable<Renderer> next) =>
                    prev.Except(next, MetadataRendererComparer.Default).
                    Concat(next.Except(prev, MetadataRendererComparer.Default));


        void RegisterSeoInfo((string pageName, string moduleName, IEnumerable<IMetadataEntity> containers) tuple) {
            var builder = AddPage(tuple.pageName);
            foreach (var container in tuple.containers)
                container.Instantiate(tuple.moduleName, builder);
        }

        static IEnumerable<(string, string, IEnumerable<IMetadataEntity>)> ExtractSeoInfoFromAssembly(Assembly assembly) =>
            assembly.GetTypes().Where(IsSeoRelatedPage).Select(ExtractSeoInfoFromType);

        static (string, string, IEnumerable<IMetadataEntity>) ExtractSeoInfoFromType(Type type) {
            return (
                type.GetCustomAttribute<RouteAttribute>()?.Template ?? DefaultMetadataCacheKey,
                type.Assembly.GetName().Name,
                type.GetCustomAttributes(false).OfType<IMetadataEntity>()
            );
        }

        static bool IsAssemblyCanContainComponents(Assembly assembly) {
            return assembly.GetReferencedAssemblies().Any(r => r.Name == RclBaseAssemblyName);
        }

        static bool IsSeoRelatedPage(Type type) {
            return type.IsClass && typeof(ComponentBase).IsAssignableFrom(type) &&
                   type.GetCustomAttributes().OfType<IMetadataEntity>().Any();
        }

        static IEnumerable<IEnumerable<Renderer>> GetRenderers(MetadataCache cache, params string[] keys) => keys.Select(x => GetRenderers(cache, x));

        static IEnumerable<Renderer> GetRenderers(MetadataCache cache, string key) =>
            cache.TryGetPageRenderers(key, out ISet<Renderer> renderers) ? renderers : Enumerable.Empty<Renderer>();

        void IDisposable.Dispose() => _cache.Clear();
    }

    sealed class DocumentMetadataObserver : IObservable<Renderer>, IDisposable {
        readonly struct Unsubscribe : IDisposable {
            readonly DocumentMetadataObserver _observable;
            readonly Action<Renderer> _subscriber;
            internal Unsubscribe(DocumentMetadataObserver observable, Action<Renderer> subscriber) {
                _subscriber = subscriber;
                _observable = observable;
                _observable._listeners += subscriber;
            }
            public void Dispose() {
                if (_observable._listeners != null) 
                    _observable._listeners -= _subscriber;
            }
        }

        readonly DocumentMetadataService _metadataService;
        readonly NavigationManager _navigationManager;

        Action<Renderer> _listeners;
        public DocumentMetadataObserver(DocumentMetadataService metadataService, NavigationManager navigationManager) {
            _metadataService = metadataService;
            _metadataService.UpdateCompleted += OnServiceUpdateCompleted;
            _navigationManager = navigationManager;
            _navigationManager.LocationChanged += OnLocationChanged;
        }


        public IDisposable Subscribe(IObserver<Renderer> observer) => SubscribeListener(observer.OnNext, observer.OnCompleted);

        IDisposable SubscribeListener(Action<Renderer> callback, Action onCompleted) {
            NotifyListener(callback);
            onCompleted();
            return new Unsubscribe(this, callback);
        }

        void OnLocationChanged(object sender, LocationChangedEventArgs e) => OnServiceUpdateCompleted();
        void OnServiceUpdateCompleted() {
            if (_listeners != null)
                NotifyListener(_listeners);
        }
        void NotifyListener(Action<Renderer> callback) {
            foreach (var renderer in _metadataService.GetRenderers(_navigationManager.GetCurrentPageName()))
                callback(renderer);
        }

        void IDisposable.Dispose() {
            _metadataService.UpdateCompleted -= OnServiceUpdateCompleted;
            _navigationManager.LocationChanged -= OnLocationChanged;
        }
    }

    sealed class DocumentMetadataBuilder : IDocumentMetadataBuilder {
        readonly ISet<Renderer> _renderers;
        readonly string _pageName;
        public override string ToString() {
            return $"{_pageName}";
        }
        internal DocumentMetadataBuilder(string pageName, ISet<Renderer> renderers) {
            _renderers = renderers;
            _pageName = pageName;
        }
        IDocumentMetadataBuilder UpdateWith(ISet<Renderer> source, in Renderer update) {
            source.Remove(update);
            source.Add(update);
            return this;
        }
        public IDocumentMetadataBuilder Base(string url) => UpdateWith(_renderers, Renderer.BaseHref(url));
        public IDocumentMetadataBuilder Title(string title) => UpdateWith(_renderers, Renderer.Title(title));
        public IDocumentMetadataBuilder TitleFormat(string format) => UpdateWith(_renderers, Renderer.TitleFormat(format));
        public IDocumentMetadataBuilder StyleSheet(string name, string url) => UpdateWith(_renderers, Renderer.Stylesheet(name, url));
        public IDocumentMetadataBuilder Script(string name, string url, bool async = false, bool defer = false) => UpdateWith(_renderers, Renderer.Script(url, async, defer));
        public IDocumentMetadataBuilder Viewport(string value) => UpdateWith(_renderers, Renderer.Viewport(value));
        public IDocumentMetadataBuilder Charset(string value) => UpdateWith(_renderers, Renderer.Charset(value));
        public IDocumentMetadataBuilder Meta(string name, string content) => UpdateWith(_renderers, Renderer.Meta(name, content));
        public IDocumentMetadataBuilder OpenGraph(string property, string content) => UpdateWith(_renderers, Renderer.OpenGraph(property, content));
    }
}
