using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace DevExpress.Blazor.Internal
{
    public class MetadataEntity
    {
        public virtual string Key { get; }
        public MetadataEntity(string name, List<KeyValuePair<string, string>> attributes)
        {
            Key = $"{name}.{string.Join("", attributes.Select(x => $"{x.Key}.{x.Value}"))}";
            Name = name;
            Attributes = new Dictionary<string, string>();
            attributes.ForEach(x => Attributes.Add(x.Key, x.Value));
        }
        protected MetadataEntity() {}
        public virtual string Name { get; }
        public virtual string Content { get; set; }
        public virtual Dictionary<string, string> Attributes { get; }
    }
    public class ActiveMetadataEntity : MetadataEntity
    {
        readonly MetadataEntity _metadataEntity;
        public int Priority { get; set; }

        public ActiveMetadataEntity(MetadataEntity src, int priority)
        {
            _metadataEntity = src;
            Priority = priority;
        }
        public override string Name => _metadataEntity.Name;
        public override string Content { get => _metadataEntity.Content; set {} }
        public override string Key => _metadataEntity.Key;
        public override Dictionary<string, string> Attributes => _metadataEntity.Attributes;
    }
    public class DocumentMetadataBuilderProvider : IDocumentMetadataSettingsProvider
    {
        readonly object _defaultSettingsKey = new object();
        readonly Dictionary<object, IDocumentMetadataSettings> _metadataBuildersLookup = new Dictionary<object, IDocumentMetadataSettings>();
        readonly IServiceProvider _serviceProvider;

        public DocumentMetadataBuilderProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IDocumentMetadataSettings GetDefault() => _metadataBuildersLookup.ContainsKey(_defaultSettingsKey) ? _metadataBuildersLookup[_defaultSettingsKey] : null;
        public IDocumentMetadataSettings GetByPageName(string pageName) => _metadataBuildersLookup.ContainsKey(pageName) ? _metadataBuildersLookup[pageName] : null;
        public IDocumentMetadataSettings CreateEmpty() => _serviceProvider.GetService<IDocumentMetadataSettings>();
        public IDocumentMetadataBuilder Default() => GetBuilderByKey(_defaultSettingsKey);
        public IDocumentMetadataBuilder Page(string pageName) => GetBuilderByKey(pageName);

        IDocumentMetadataBuilder GetBuilderByKey(object key)
        {
            var builder = CreateEmpty();
            _metadataBuildersLookup[key] = builder;
            return builder;
        }
    }
    public class DocumentMetadataSettings : IDocumentMetadataSettings
    {
        readonly List<MetadataEntity> _entitiesToApply = new List<MetadataEntity>();

        public IDocumentMetadataBuilder Base(string url)
        {
            GetOrAddElement("base").Attributes["href"] = url;
            return this;
        }
        public IDocumentMetadataBuilder Title(string title)
        {
            GetOrAddElement("title").Content = title;
            return this;
        }
        public IDocumentMetadataBuilder TitleFormat(string format)
        {
            GetOrAddElement("titleFormat").Content = format;
            return this;
        }
        public IDocumentMetadataBuilder StyleSheet(string name, string styleSheetUrl)
        {
            GetOrAddElement("link", "rel", "stylesheet", "id", name).Attributes["href"] = styleSheetUrl;
            return this;
        }
        public IDocumentMetadataBuilder Script(string name, string scriptUrl, bool async = false, bool defer = false)
        {
            var attributeTuples = new List<string>();
            attributeTuples.Add("type");
            attributeTuples.Add("text/javascript");
            attributeTuples.Add("id");
            attributeTuples.Add(name);
            if (async)
            {
                attributeTuples.Add("async");
                attributeTuples.Add(string.Empty);
            }
            if (defer)
            {
                attributeTuples.Add("defer");
                attributeTuples.Add(string.Empty);
            }
            GetOrAddElement("script", attributeTuples.ToArray()).Attributes["src"] = scriptUrl;
            return this;
        }
        public IDocumentMetadataBuilder Viewport(string value) => Meta("viewport", value);
        public IDocumentMetadataBuilder Charset(string value) => MetaInfo("charset", value, null);
        public IDocumentMetadataBuilder Meta(string name, string content) => MetaInfo("name", name, content);
        public IDocumentMetadataBuilder OpenGraph(string property, string content) => MetaInfo("property", "og:" + property, content);


        public Action Apply(DocumentMetadataContainer meta)
        {
            int nextPriority = meta.Entities.Any() ? meta.Entities.Max(x => x.Priority) + 1 : 0;
            var appliedMetaElements = _entitiesToApply.Select(x => new ActiveMetadataEntity(x, nextPriority)).ToList();
            meta.Entities.AddRange(appliedMetaElements);
            return () => appliedMetaElements.ForEach(x => meta.Entities.Remove(x));
        }

        IDocumentMetadataBuilder MetaInfo(string key, string name, string value)
        {
            GetOrAddElement("meta", key, name).Attributes["content"] = value;
            return this;
        }
        MetadataEntity GetOrAddElement(string name, params string[] attributePairs)
        {
            var attributes = new List<KeyValuePair<string, string>>();
            for(int i = 0; i < attributePairs.Length; i+=2)
                attributes.Add(new KeyValuePair<string, string>(attributePairs[i], attributePairs.ElementAtOrDefault(i + 1)));

            MetadataEntity element = _entitiesToApply.FirstOrDefault(x => 
                x.Name == name && 
                attributes.All(a => x.Attributes.ContainsKey(a.Key) && (string.IsNullOrEmpty(a.Value) || x.Attributes[a.Key] == a.Value)));
            if(element == null) {
                element = new MetadataEntity(name, attributes);
                _entitiesToApply.Add(element);
            }
            return element;
        }
    }
    public class DocumentMetadataService : IDocumentMetadataService, IDocumentMetadataContainerOwner, IDisposable
    {
        public event EventHandler OnMetadataUpdated;
        public DocumentMetadataContainer Metadata { get; } = new DocumentMetadataContainer();

        protected IDocumentMetadataSettingsProvider MetadataProvider { get; private set; }
        protected IUriHelper UriHelper { get; private set; }

        protected Action RevertPageSpecificMetaData { get; private set; }
        protected string PageName { get; private set; }

        public DocumentMetadataService(IDocumentMetadataSettingsProvider metadataProvider, IUriHelper uriHelper)
        {
            UriHelper = uriHelper;
            MetadataProvider = metadataProvider;
            UriHelper.OnLocationChanged += OnLocationChanged;
            MetadataProvider.GetDefault()?.Apply(Metadata);
            LoadMetadataForPage(GetPageNameByLocation(UriHelper.GetAbsoluteUri()));
        }

        public void Update(Action<IDocumentMetadataBuilder> update)
        {
            var settings = MetadataProvider.CreateEmpty();
            update(settings);
            settings.Apply(Metadata);
            OnMetadataUpdated?.Invoke(this, EventArgs.Empty);
        }

        void OnLocationChanged(object sender, LocationChangedEventArgs e) => LoadMetadataForPage(GetPageNameByLocation(e.Location));
        void LoadMetadataForPage(string pageName)
        {
            if (PageName != pageName)
            {
                PageName = pageName;
                bool hasChanges = RevertPageSpecificMetaData != null;
                if (hasChanges)
                    RevertPageSpecificMetaData();
                var builder = MetadataProvider.GetByPageName(PageName);
                if (hasChanges = (hasChanges || builder != null))
                    RevertPageSpecificMetaData = builder?.Apply(Metadata);

                if (hasChanges)
                    OnMetadataUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        string GetPageNameByLocation(string location) => UriHelper.ToBaseRelativePath(UriHelper.GetBaseUri(), location);

        void IDisposable.Dispose()
        {
            if(UriHelper != null)
                UriHelper.OnLocationChanged -= OnLocationChanged;
            MetadataProvider = null;
            UriHelper = null;
            RevertPageSpecificMetaData = null;
        }
    }
}
