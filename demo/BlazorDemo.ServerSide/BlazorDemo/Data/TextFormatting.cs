using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {
    public class TextFormatting {
        public Dictionary<string, bool> Decoration { get; } = new Dictionary<string, bool>() {
            { "Bold", false },
            { "Italic" , false },
            { "Underline" , false },
            { "Strikethrough" , false },
            { "Overline" , false }
        };

        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public string TextCase { get; set; }
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
        public bool GetIsChanged() {
            return TextCase != null || FontFamily != null || FontSize != 0 || Decoration.Values.Any(x => x);
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
}
