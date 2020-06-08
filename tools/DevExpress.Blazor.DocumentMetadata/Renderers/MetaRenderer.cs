using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata {
    public readonly partial struct Renderer {
        
        public static Renderer Meta(string name, string content) {
            return  new Renderer(RendererFlag.Meta | RendererFlag.UniqueByName, content, name);
        }
        
        public int MetaRender(RenderTreeBuilder renderTreeBuilder, int seq, NavigationManager _) {
            renderTreeBuilder.OpenElement(seq + 0, "meta");
            renderTreeBuilder.AddAttribute(seq + 1, "name", _name);
            renderTreeBuilder.AddAttribute(seq + 2, "content", _mainAttributeValue);
            renderTreeBuilder.CloseElement();
            return seq + 3;
        }
    }
}
