using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DevExpress.Blazor.DocumentMetadata {

    interface IMetadataEntity {
        void Instantiate(string moduleName, IDocumentMetadataBuilder builder);
    }

    public interface IDocumentMetadataBuilder {
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
    public interface IDocumentMetadataService {
        void Update(Action<IDocumentMetadataBuilder> update);
    }
    public interface IDocumentMetadataCollection {
        IDocumentMetadataBuilder AddDefault();
        IDocumentMetadataBuilder AddPage(string pageName);
    }
    public static partial class DocumentMetadataExtensions {
        public static IServiceCollection AddDocumentMetadata(this IServiceCollection services) {
            services.TryAddSingleton<DocumentMetadataSetup>(_ => new DocumentMetadataSetup());
            services.AddScoped<DocumentMetadataService>();
            services.AddScoped<IDocumentMetadataService>(sp => sp.GetService<DocumentMetadataService>());
            services.AddScoped<IDocumentMetadataCollection>(sp => sp.GetService<DocumentMetadataService>());
            services.AddScoped<IObservable<Renderer>, DocumentMetadataObserver>();
            return services;
        }

    }
}
