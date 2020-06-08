namespace BlazorDemo.Configuration {
    public class SeoConfiguration {
        public string TitleFormat { get; set; }
        public DemoPage[] RootDemoPages { get; set; }
        public DemoProductInfo[] Products { get; set; }
        public string AssemblyName { get; set; }
    }
}