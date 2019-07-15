using System;
using System.Collections.Generic;
using DevExpress.Blazor.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace DevExpress.Blazor.Internal
{
    using DevExpress.Blazor.DocumentMetadata;

    public class DocumentMetadataContainer
    {
        internal List<ActiveMetadataEntity> Entities { get; } = new List<ActiveMetadataEntity>();
    }
    public interface IDocumentMetadataContainerOwner
    {
        DocumentMetadataContainer Metadata { get; }
        event EventHandler OnMetadataUpdated;
        bool CheckBeforeRender(MetadataEntity entity);
        string ResolveUrl(string attrValue);
    }
    public interface IDocumentMetadataSettings : IDocumentMetadataBuilder
    {
        Action Apply(DocumentMetadataContainer metadata);
    }
    public interface IDocumentMetadataSettingsProvider : IDocumentMetadataRegistrator
    {
        IDocumentMetadataSettings GetDefault();
        IDocumentMetadataSettings GetByPageName(string pageName);
        IDocumentMetadataSettings CreateEmpty();
    }
}

namespace DevExpress.Blazor.DocumentMetadata
{

    public interface IDocumentMetadataBuilder
    {
        IDocumentMetadataBuilder Base(string url);
        IDocumentMetadataBuilder Title(string title);
        IDocumentMetadataBuilder TitleFormat(string format);
        IDocumentMetadataBuilder Charset(string value);
        IDocumentMetadataBuilder Viewport(string value);
        IDocumentMetadataBuilder Meta(string name, string content);
        IDocumentMetadataBuilder OpenGraph(string property, string content);
        IDocumentMetadataBuilder StyleSheet(string name, string styleSheetUrl);
        IDocumentMetadataBuilder Script(string name, string scriptUrl, bool async = false, bool defer = false);
    }
    public interface IDocumentMetadataService
    {
        void Update(Action<IDocumentMetadataBuilder> update);
    }
    public interface IDocumentMetadataRegistrator
    {
        IDocumentMetadataBuilder Default();
        IDocumentMetadataBuilder Page(string pageName);
    }
    public static class DocumentMetadataExtensions
    {
        public static IServiceCollection AddDocumentMetadata(this IServiceCollection services, Action<IServiceProvider, IDocumentMetadataRegistrator> initialize)
        {
            services.AddTransient<IDocumentMetadataSettings, DocumentMetadataSettings>();

            services.AddScoped<DocumentMetadataService>();
            services.AddScoped<IDocumentMetadataService>(serviceProvider => serviceProvider.GetService<DocumentMetadataService>());
            services.AddScoped<IDocumentMetadataContainerOwner>(serviceProvider => serviceProvider.GetService<DocumentMetadataService>());

            services.AddSingleton<IDocumentMetadataSettingsProvider>((serviceProvider) =>
            {
                var provider = new DocumentMetadataBuilderProvider(serviceProvider);
                initialize(serviceProvider, provider);
                return provider;
            });
            return services;
        }
    }
}
