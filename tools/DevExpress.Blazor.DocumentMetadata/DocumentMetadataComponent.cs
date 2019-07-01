using System;
using System.Linq;
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
            var entities = MetadataContainerOwner.Metadata.Entities.GroupBy(x => x.Key).Select(x => x.OrderBy(i => i.Priority).Last()).ToList();
            string titleFormat = entities.FirstOrDefault(x => x.Name == "titleFormat")?.Content ?? "{0}";
            builder.AddContent(0, new MarkupString(Environment.NewLine));
            foreach (var entity in entities)
            {
                if(entity.Name == "titleFormat") continue;
                builder.OpenElement(1, entity.Name);
                builder.SetKey(entity);
                foreach (var item in entity.Attributes)
                {
                    builder.SetKey(item);
                    string attrValue = item.Value;
                    switch (item.Key)
                    {
                        case "src":
                        case "href":
                            attrValue = GetFixedUrl(attrValue);
                            break;
                    }
                    if (!string.IsNullOrEmpty(attrValue))
                        builder.AddAttribute(2, item.Key, attrValue);
                    else
                        builder.AddAttribute(2, item.Key, true);
                }
                if(entity.Name == "title")
                    builder.AddContent(4, string.Format(titleFormat, entity.Content));
                builder.CloseElement();
                builder.AddContent(5, new MarkupString(Environment.NewLine));
            }
        }

        protected override void OnInit()
        {
            MetadataContainerOwner.OnMetadataUpdated += OnMetadataUpdated;
            base.OnInit();
        }

        void OnMetadataUpdated(object sender, EventArgs e) {
            StateHasChanged();
        }

        string GetFixedUrl(string url)
        {
            if (url.StartsWith("~/"))
            {
                string baseUrl = UriHelper.GetBaseUri();
                string absoluteUrl = baseUrl + url.Substring(2);
                url = UriHelper.ToBaseRelativePath(baseUrl, absoluteUrl);
                url = UriHelper.ToAbsoluteUri(url).PathAndQuery;
            }
            return url;
        }

        void IDisposable.Dispose()
        {
            MetadataContainerOwner.OnMetadataUpdated -= OnMetadataUpdated;
        }
    }
}
