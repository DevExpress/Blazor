using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata
{
    public readonly partial struct Renderer {
        
        public static Renderer Stylesheet(string id, string url) {
            if (string.IsNullOrEmpty(id))
                id = url;
            return  new Renderer(RendererFlag.Stylesheet | RendererFlag.UniqueByName, url, id);
        }
        
        public int StylesheetRender(RenderTreeBuilder renderTreeBuilder, int seq, NavigationManager navigationManager) {
            renderTreeBuilder.OpenElement(seq + 0, "link");
            renderTreeBuilder.AddAttribute(seq + 1, "href", navigationManager.ResolveUrl(_mainAttributeValue));
            renderTreeBuilder.AddAttribute(seq + 2, "rel", "stylesheet");
            if (!string.IsNullOrEmpty(_name) && _name != _mainAttributeValue)
                renderTreeBuilder.AddAttribute(seq + 3, "id", _name);
            renderTreeBuilder.CloseElement();
            return seq + 4;
        }
    }
}