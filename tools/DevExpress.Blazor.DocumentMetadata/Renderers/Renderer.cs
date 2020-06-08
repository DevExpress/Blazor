using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata {
    [Flags]
    public enum RendererFlag {
        BaseHref = 0,
        Charset = 1 << 1,
        Meta = 1 << 2,
        OpenGraph = 1 << 3,
        Script = 1 << 4,
        Title = 1 << 5,
        TitleFormat = 1 << 6,
        Stylesheet = 1 << 7,

        UniqueByType = 1 << 8,
        UniqueByName = 1 << 9
    }

    [JsonConverter(typeof(RendererJsonConverter))]
    public readonly partial struct Renderer : IEquatable<Renderer> {
        private readonly RendererFlag _flag;
        private readonly string _name;
        private readonly string _mainAttributeValue;
        private readonly int _optionalAttributes;

        private Renderer(RendererFlag flag, string mainAttributeValue, string name = null, int optionalAttributes = 0) {
            _flag = flag;
            _name = name;
            _mainAttributeValue = mainAttributeValue;
            _optionalAttributes = optionalAttributes;
        }

        public int Render(RenderTreeBuilder renderTreeBuilder, int seq, NavigationManager navigationManager) {
            switch (GetTypeFlagValue(_flag)) {
                case RendererFlag.Charset: return CharsetRender(renderTreeBuilder, seq, navigationManager);
                case RendererFlag.BaseHref: return BaseHrefRender(renderTreeBuilder, seq, navigationManager);
                case RendererFlag.Meta: return MetaRender(renderTreeBuilder, seq, navigationManager);
                case RendererFlag.Script: return ScriptRender(renderTreeBuilder, seq, navigationManager);
                case RendererFlag.Stylesheet: return StylesheetRender(renderTreeBuilder, seq, navigationManager);
                case RendererFlag.Title: return TitleRender(renderTreeBuilder, seq, navigationManager);
            }
            return seq;
        }

        public bool Equals(Renderer other) {
            if ((_flag & RendererFlag.UniqueByName) == 0 && _name != other._name)
                return false;
            if (GetTypeFlagValue(_flag) != GetTypeFlagValue(other._flag))
                return false;
            return true;
        }
        public override bool Equals(object obj) {
            return Equals((Renderer)obj);
        }
        public override int GetHashCode() {
            return (_flag, _name).GetHashCode();
        }

        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }

        static RendererFlag GetTypeFlagValue(RendererFlag flag) {
            return (RendererFlag)(byte)flag;
        }
        
        
        class RendererJsonConverter : JsonConverter<Renderer> {
            public override Renderer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                return default;
            }
            public override void Write(Utf8JsonWriter writer, Renderer value, JsonSerializerOptions options) {
                writer.WriteStartObject();
                writer.WriteNumber("flag", (int)value._flag);
                if (!string.IsNullOrEmpty(value._name))
                    writer.WriteString("name", value._name);
                if (!string.IsNullOrEmpty(value._mainAttributeValue))
                    writer.WriteString("value", value._mainAttributeValue);
                if (value._optionalAttributes != 0)
                    writer.WriteNumber("opt", value._optionalAttributes);
                writer.WriteEndObject();
            }
        }
    }
    
}