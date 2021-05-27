namespace BlazorDemo.Data {
    public class FontInfo {
        public string Name { get; private set; }
        public string CssString { get; private set; }
        public FontInfo(string name, string cssString) {
            Name = name;
            CssString = cssString;
        }
        public string GetCssString() {
            return $"font-family:{CssString};";
        }
        public static readonly FontInfo[] DefaultFonts = new FontInfo[] {
                new FontInfo("Arial", "Arial, Helvetica, sans-serif"),
                new FontInfo("Courier New", "'Courier New', Courier, monospace"),
                new FontInfo("Segoe UI", "'Segoe UI', sans-serif"),
                new FontInfo("Tahoma", "Tahoma, Geneva, sans-serif"),
                new FontInfo("Times New Roman", "'Times New Roman', Times, serif"),
                new FontInfo("Verdana", "Verdana, Geneva, sans-serif"),
            };
    }
}
