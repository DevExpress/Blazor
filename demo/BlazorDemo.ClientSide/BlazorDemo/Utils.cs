namespace BlazorDemo {
    class StaticAssetUtils {
        static string libraryPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        public static string GetContentPath(string assetPath) {
            return $"./_content/{libraryPath}/{assetPath}";
        }

        public static string GetImagePath(string imageFileName) {
            return GetContentPath($"images/{imageFileName}");
        }
    }
}
