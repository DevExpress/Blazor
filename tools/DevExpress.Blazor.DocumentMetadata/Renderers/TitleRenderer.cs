using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata {
    public readonly partial struct Renderer {

        public static Renderer Title(string value) {
            return  new Renderer(RendererFlag.Title | RendererFlag.UniqueByType, value);
        }

        public static Renderer TitleFormat(string value) {
            return  new Renderer(RendererFlag.TitleFormat | RendererFlag.UniqueByType, value);
        }

        public int TitleRender(RenderTreeBuilder renderTreeBuilder, int seq, NavigationManager navigationManager) {
            renderTreeBuilder.OpenElement(seq + 0, "title");
            renderTreeBuilder.AddContent(seq + 1, string.Format("{0}", _mainAttributeValue));
            renderTreeBuilder.CloseElement();
            return seq + 2;
        }
        public int TitleFormatRender(RenderTreeBuilder renderTreeBuilder, int seq, NavigationManager _) {
            return seq;
        }
    }
}
