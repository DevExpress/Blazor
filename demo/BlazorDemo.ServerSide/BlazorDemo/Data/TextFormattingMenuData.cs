using System.Collections.Generic;

namespace BlazorDemo.Data {
    static class TextFormattingMenu {
        public static TextFormattingMenuItem FontFamilyMenuItem(TextFormatting textFormatting) =>
            new TextFormattingParentMenuItem(textFormatting, "Font", new List<TextFormattingMenuItem>() {
                new FontFamilyMenuItem(textFormatting, "Times New Roman", "Times New Roman"),
                new FontFamilyMenuItem(textFormatting, "Tahoma", "Tahoma"),
                new FontFamilyMenuItem(textFormatting, "Verdana", "Verdana"),
                new FontFamilyMenuItem(textFormatting, "Arial", "Arial"),
                new FontFamilyMenuItem(textFormatting, "MS Sans Serif", "MS Sans Serif"),
                new FontFamilyMenuItem(textFormatting, "Courier", "Courier"),
                new FontFamilyMenuItem(textFormatting, "Segoe UI", "Segoe UI"),
                new FontFamilyMenuItem(textFormatting, "Default", null) { BeginGroup = true }
            });
        public static TextFormattingMenuItem FontSizeMenuItem(TextFormatting textFormatting) =>
            new TextFormattingParentMenuItem(textFormatting, "Size", new List<TextFormattingMenuItem>() {
                new FontSizeMenuItem(textFormatting, "8pt", 8),
                new FontSizeMenuItem(textFormatting, "10pt", 10),
                new FontSizeMenuItem(textFormatting, "12pt", 12),
                new FontSizeMenuItem(textFormatting, "14pt", 14),
                new FontSizeMenuItem(textFormatting, "18pt", 18),
                new FontSizeMenuItem(textFormatting, "24pt", 24),
                new FontSizeMenuItem(textFormatting, "36pt", 36),
                new FontSizeMenuItem(textFormatting, "Default", 0) { BeginGroup = true }
            });
        static TextFormattingMenuItem FontFormattingMenuItem(TextFormatting textFormatting) =>
            new TextFormattingParentMenuItem(textFormatting, "Style", new List<TextFormattingMenuItem>() {
                new TextDecorationMenuItem(textFormatting, "Bold", "Bold"),
                new TextDecorationMenuItem(textFormatting, "Italic", "Italic"),
                new TextDecorationMenuItem(textFormatting, "Underline", "Underline"),
                new TextDecorationMenuItem(textFormatting, "Overline", "Overline"),
                new TextDecorationMenuItem(textFormatting, "Strikethrough", "Strikethrough")
            });

        public static List<TextFormattingMenuItem> ContextMenuItems(TextFormatting textFormatting) =>
            new List<TextFormattingMenuItem>() {
                FontFamilyMenuItem(textFormatting),
                FontSizeMenuItem(textFormatting),
                FontFormattingMenuItem(textFormatting),
                new ClearFormattingMenuItem(textFormatting) { BeginGroup = true }
            };

        public static List<TextFormattingMenuItem> MenuItems(TextFormatting textFormatting) =>
            new List<TextFormattingMenuItem>() {
                FontFamilyMenuItem(textFormatting),
                FontSizeMenuItem(textFormatting),
                new ClearFormattingMenuItem(textFormatting) { BeginGroup = false }
            };
    }
}
