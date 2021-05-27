namespace BlazorDemo.Data {
    public class FontSizeInfo {
        public int Size { get; private set; }

        public FontSizeInfo(int size) {
            Size = size;
        }
        public static readonly FontSizeInfo[] DefaultFontSizes = new FontSizeInfo[] {
                new FontSizeInfo(8),
                new FontSizeInfo(10),
                new FontSizeInfo(12),
                new FontSizeInfo(14),
                new FontSizeInfo(18),
                new FontSizeInfo(24),
                new FontSizeInfo(36),
            };
    }
}
