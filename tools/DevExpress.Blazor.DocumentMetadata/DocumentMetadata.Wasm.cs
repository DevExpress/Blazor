using System;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DevExpress.Blazor.DocumentMetadata {


    public static partial class DocumentMetadataExtensions {
        public static void AddDocumentMetadata(this IServiceCollection services, Action<IServiceProvider, IDocumentMetadataCollection> initialize) {
            services.AddSingleton(new DocumentMetadataSetup(initialize));
            services.AddDocumentMetadata();
        }

        public static void AddDocumentMetadata(this WebAssemblyHostBuilder hostBuilder,
            Action<IServiceProvider, IDocumentMetadataCollection> initialize) {

            hostBuilder.RootComponents.AddDocumentMetadata();
            hostBuilder.Services.AddDocumentMetadata(initialize);
        }
        public static void AddDocumentMetadata(this RootComponentMappingCollection rootComponents) {
            rootComponents.Add<WebAssemblyMetadataManager>("meta[data-dxmetadatamanager]");
        }

    }
}
