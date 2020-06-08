using System;

namespace DevExpress.Blazor.DocumentMetadata {

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class RequireJavascriptApiAttribute : Attribute, IMetadataEntity {
        readonly string _moduleLoaderName;

        public RequireJavascriptApiAttribute(string moduleLoaderName) {
            if (string.IsNullOrEmpty(moduleLoaderName)) throw new ArgumentException(nameof(moduleLoaderName));

            _moduleLoaderName = moduleLoaderName;
        }

        void IMetadataEntity.Instantiate(string assemblyName, IDocumentMetadataBuilder builder) =>
            builder.Script(_moduleLoaderName, $"~/_content/{assemblyName}/{_moduleLoaderName}", async: true);
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class SeoTitleAttribute : Attribute, IMetadataEntity {
        readonly string _title;

        public SeoTitleAttribute(string title) {
            if (string.IsNullOrEmpty(title)) throw new ArgumentException(nameof(title));

            _title = title;
        }

        void IMetadataEntity.Instantiate(string _, IDocumentMetadataBuilder builder) => builder.Title(_title);
    }


    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class SeoKeywordsAttribute : Attribute, IMetadataEntity {
        readonly string _keywords;

        public SeoKeywordsAttribute(string keywords) {
            if (string.IsNullOrEmpty(keywords)) throw new ArgumentException(nameof(keywords));

            _keywords = keywords;
        }

        void IMetadataEntity.Instantiate(string _, IDocumentMetadataBuilder builder) => builder.Meta("keywords", _keywords);
    }


    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class SeoDescriptionAttribute : Attribute, IMetadataEntity {
        readonly string _description;

        public SeoDescriptionAttribute(string description) {
            if (string.IsNullOrEmpty(description)) throw new ArgumentException(nameof(description));

            _description = description;
        }

        void IMetadataEntity.Instantiate(string _, IDocumentMetadataBuilder builder) => builder.Meta("description", _description);
    }

}
