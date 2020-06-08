using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata
{
    public readonly partial struct Renderer {
        public static Renderer Viewport(string value) {
            return Meta("viewport", value);
        }
    }
}