using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Data {

    public class TextFormatting {
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public string TextCase { get; set; }
        public Dictionary<string, bool> Decoration { get; } = new Dictionary<string, bool>() {
            { "Bold", false },
            { "Italic" , false },
            { "Underline" , false },
            { "Strikethrough" , false },
            { "Overline" , false }
        };

        string GetTextDecoration() {
            string textDecoration = "";
            if(Decoration["Underline"])
                textDecoration += "underline";
            if(Decoration["Overline"])
                textDecoration += " overline";
            if(Decoration["Strikethrough"])
                textDecoration += " line-through";
            return textDecoration;
        }

        public string GetStyleString() {
            string style = "";
            if(!string.IsNullOrEmpty(FontFamily))
                style += $"font-family: {FontFamily}; ";
            if(FontSize > 0)
                style += $"font-size: {FontSize}pt; ";
            if(Decoration["Bold"])
                style += "font-weight: bold; ";
            if(Decoration["Italic"])
                style += "font-style: italic; ";
            if(!string.IsNullOrEmpty(TextCase))
                style += $"text-transform: {TextCase}; ";

            string textDecoration = GetTextDecoration();
            if(!string.IsNullOrEmpty(textDecoration))
                style += $"text-decoration: {textDecoration};";
            return !string.IsNullOrEmpty(style) ? style : null;
        }

        public void ClearFormatting() {
            TextCase = null;
            FontFamily = null;
            FontSize = 0;
            Decoration["Bold"] = false;
            Decoration["Italic"] = false;
            Decoration["Underline"] = false;
            Decoration["Overline"] = false;
            Decoration["Strikethrough"] = false;
        }
    }

    abstract class TextFormattingMenuItem {
        protected TextFormattingMenuItem(TextFormatting textFormatting, string text) {
            TextFormatting = textFormatting;
            Text = text;
        }

        public TextFormatting TextFormatting { get; }
        public string Text { get; }
        public virtual void Click() { }
        public List<TextFormattingMenuItem> Children { get; set; }
        public bool BeginGroup { get; set; }
        public virtual string IconUrl { get { return null; } }
        public string IconCss { get; set; }
        public virtual bool Checked { get; protected set; }
        public bool SplitMenuButton { get; set; }
        public string Category { get; set; }
    }

    class TextFormattingParentMenuItem : TextFormattingMenuItem {
        public TextFormattingParentMenuItem(TextFormatting textFormatting, string text, List<TextFormattingMenuItem> children) : base(textFormatting, text) {
            Children = children;
        }
    }

    class FontFamilyMenuItem : TextFormattingMenuItem {
        public FontFamilyMenuItem(TextFormatting textFormatting, string text, string fontFamily) : base(textFormatting, text) {
            FontFamily = fontFamily;
        }

        string FontFamily { get; }
        public override void Click() {
            TextFormatting.FontFamily = FontFamily;
        }
    }

    class FontSizeMenuItem : TextFormattingMenuItem {
        public FontSizeMenuItem(TextFormatting textFormatting, string text, int fontSize) : base(textFormatting, text) {
            FontSize = fontSize;
        }

        int FontSize { get; }
        public override void Click() {
            TextFormatting.FontSize = FontSize;
        }
    }

    class TextDecorationMenuItem : TextFormattingMenuItem {
        public TextDecorationMenuItem(TextFormatting textFormatting, string text, string attributeName) : base(textFormatting, text) {
            AttributeName = attributeName;
        }

        string AttributeName { get; }
        public override bool Checked { get { return TextFormatting.Decoration[AttributeName]; } protected set { TextFormatting.Decoration[AttributeName] = value; } }

        public override string IconUrl { get { return Checked ? StaticAssetUtils.GetImagePath("check.svg") : null; } }

        public override void Click() {
            Checked = !Checked;
        }
    }
    class ChangeCaseMenuItem : TextFormattingMenuItem {
        public ChangeCaseMenuItem(TextFormatting textFormatting, string text, string textCase) : base(textFormatting, text) {
            TextCase = textCase;
        }

        string TextCase { get; }
        public override void Click() {
            TextFormatting.TextCase = TextCase;
        }
    }
    class ClearFormattingMenuItem : TextFormattingMenuItem {
        public ClearFormattingMenuItem(TextFormatting textFormatting) : base(textFormatting, "Clear Formatting") { }

        public override void Click() {
            TextFormatting.ClearFormatting();
        }
    }
}
