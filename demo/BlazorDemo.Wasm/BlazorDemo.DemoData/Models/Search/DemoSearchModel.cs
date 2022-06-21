namespace BlazorDemo.DemoData {
    public class DemoSearchModel {
        public DemoSynonymsSearchModel Synonyms { get; set; }
        public DemoExclusionsSearchModel Exclusions { get; set; }
    }

    public class DemoExclusionsSearchModel {
        public string Words { get; set; }
        public string Prefixes { get; set; }
        public string Postfixes { get; set; }
    }
    public class DemoSynonymsSearchModel {
        public string[] Groups { get; set; }
    }
}
