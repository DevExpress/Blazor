using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata
{
    public readonly partial struct Renderer {
        
        public static Renderer Charset(string value) {
            return  new Renderer(RendererFlag.Charset | RendererFlag.UniqueByType, value);
        }
        
        public int CharsetRender(RenderTreeBuilder renderTreeBuilder, int seq, NavigationManager _) {
            renderTreeBuilder.OpenElement(seq + 0, "meta");
            renderTreeBuilder.AddAttribute(seq + 1, "charset", _mainAttributeValue);
            renderTreeBuilder.CloseElement();
            return seq + 2;
        }
    }
}