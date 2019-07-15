using System;
using System.Linq;
using System.Text;
using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace DevExpress.Blazor.DocumentMetadata
{
    public class DocumentMetadataComponent : ComponentBase, IDisposable
    {
        [Inject] public IDocumentMetadataContainerOwner MetadataContainerOwner { get; set; }
        [Inject] public IUriHelper UriHelper { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var entities = MetadataContainerOwner.Metadata.Entities.GroupBy(x => x.Key).Select(x => x.OrderBy(i => i.Priority).Last().Origin).ToList();
            string titleFormat = entities.FirstOrDefault(x => x.Name == "titleFormat")?.Content ?? "{0}";
            builder.AddContent(0, new MarkupString(Environment.NewLine));
            foreach (var entity in entities)
            {
                if(!MetadataContainerOwner.CheckBeforeRender(entity)) continue;
                builder.OpenComponent<DocumentMetadataEntityComponent>(1);
                builder.SetKey(entity.Key);
                builder.AddAttribute(2, "EntityOrigin", entity);
                builder.AddAttribute(3, "TitleFormat", titleFormat);
                builder.CloseComponent();
            }
        }

        protected override void OnInit()
        {
            MetadataContainerOwner.OnMetadataUpdated += OnMetadataUpdated;
            base.OnInit();
        }

        void OnMetadataUpdated(object sender, EventArgs e) {
            Invoke(StateHasChanged);
        }

        void IDisposable.Dispose()
        {
            MetadataContainerOwner.OnMetadataUpdated -= OnMetadataUpdated;
        }
    }

    public class DocumentMetadataEntityComponent : ComponentBase, IDisposable
    {
        [Inject] public IUriHelper UriHelper { get; set; }
        [Inject] public IDocumentMetadataContainerOwner MetadataContainerOwner { get; set; }
        [Parameter] public MetadataEntity EntityOrigin { get; set; }
        [Parameter] public string TitleFormat { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            builder.AddMarkupContent(0, GetEntityRender());
        }

        string GetEntityRender() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<{EntityOrigin.Name}");
            foreach (var item in EntityOrigin.Attributes) {
                string attrValue = item.Value;
                switch (item.Key) {
                    case "src":
                    case "href":
                        attrValue = MetadataContainerOwner.ResolveUrl(attrValue);
                        break;
                }
                if (!string.IsNullOrEmpty(attrValue))
                    sb.Append($" {item.Key}=\"{attrValue}\"");
                else
                    sb.Append($" {item.Key}");
            }
            if (EntityOrigin.Name == "script" || !string.IsNullOrEmpty(EntityOrigin.Content)) {
                sb.Append(">");
                sb.Append(EntityOrigin.Content);
                sb.Append($"</{EntityOrigin.Name}>");
            } else
                sb.Append("/>");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        public void Dispose() {
            EntityOrigin = null;
            UriHelper = null;
            MetadataContainerOwner = null;
        }
    }
}
