using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DevExpress.Blazor.DocumentMetadata {
    [HtmlTargetElement("head")]
    sealed class DocumentMetadataTagHelperComponent : TagHelperComponent {
        readonly IHtmlHelper _html;
        [HtmlAttributeNotBound] [ViewContext] public ViewContext ViewContext { get; set; }

        public override int Order => 2;

        public DocumentMetadataTagHelperComponent(IHtmlHelper html) {
            _html = html;
        }

        public override async Task ProcessAsync(TagHelperContext context,
            TagHelperOutput output) {
            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase)) {
                ((IViewContextAware)_html).Contextualize(ViewContext);
                output.PreContent.AppendHtml(
                    await _html.RenderComponentAsync<MetadataMarkupStaticRenderComponent>(RenderMode.Static));
                output.PostContent.AppendHtml(
                    await _html.RenderComponentAsync<MetadataManagerComponent>(RenderMode.Server));
            }
        }
    }
}