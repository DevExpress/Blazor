using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {
    abstract class TextFormattingMenuItem {
        protected TextFormattingMenuItem(TextFormatting textFormatting, string text) {
            TextFormatting = textFormatting;
            Text = text;
        }

        public TextFormatting TextFormatting { get; }
        public virtual string Text { get; }
        public virtual bool Checked { get; }
        public List<TextFormattingMenuItem> Children { get; set; }
        public bool BeginGroup { get; set; }
        public string IconCss { get; set; }
        public string CssClass { get { return Checked ? "checked-item" : ""; } }
        public string IconUrl { get { return Checked ? StaticAssetUtils.GetImagePath("icons/check.svg") : null; } }
        public bool SplitMenuButton { get; set; }
        public string Category { get; set; }
        public string Tooltip { get; set; }
        public virtual bool Enabled => true;
        public virtual void Click() { }
    }

    class TextFormattingParentMenuItem : TextFormattingMenuItem {
        public TextFormattingParentMenuItem(TextFormatting textFormatting, string text, List<TextFormattingMenuItem> children)
            : base(textFormatting, text) {
            Children = children;
        }
    }

    class FontFamilyMenuItem : TextFormattingMenuItem {
        public FontFamilyMenuItem(TextFormatting textFormatting, string text, string fontFamily)
            : base(textFormatting, text) {
            FontFamily = fontFamily;
        }
        public override bool Checked { get => TextFormatting.FontFamily == FontFamily; }
        string FontFamily { get; }
        public override void Click() {
            TextFormatting.FontFamily = FontFamily;
        }
    }

    class FontSizeMenuItem : TextFormattingMenuItem {
        public FontSizeMenuItem(TextFormatting textFormatting, string text, int fontSize)
            : base(textFormatting, text) {
            FontSize = fontSize;
        }
        public override bool Checked { get => TextFormatting.FontSize == FontSize; }
        int FontSize { get; }
        public override void Click() {
            TextFormatting.FontSize = FontSize;
        }
    }

    class TextDecorationMenuItem : TextFormattingMenuItem {
        public TextDecorationMenuItem(TextFormatting textFormatting, string text, string attributeName)
            : base(textFormatting, text) {
            AttributeName = attributeName;
        }

        string AttributeName { get; }
        public override bool Checked {
            get { return TextFormatting.Decoration[AttributeName]; }
        }

        public override void Click() {
            TextFormatting.Decoration[AttributeName] = !Checked;
        }
    }

    class ChangeCaseMenuItem : TextFormattingMenuItem {
        public ChangeCaseMenuItem(TextFormatting textFormatting, string text, string textCase)
            : base(textFormatting, text) {
            TextCase = textCase;
        }

        string TextCase { get; }
        public override void Click() {
            TextFormatting.TextCase = TextCase;
        }
        public override bool Checked { get => TextFormatting.TextCase == TextCase; }
    }

    class ClearFormattingMenuItem : TextFormattingMenuItem {
        public ClearFormattingMenuItem(TextFormatting textFormatting)
            : base(textFormatting, "Clear Formatting") {
        }

        public override bool Enabled => TextFormatting.IsStyleChanged();

        public override void Click() {
            TextFormatting.ClearFormatting();
        }
    }
}
