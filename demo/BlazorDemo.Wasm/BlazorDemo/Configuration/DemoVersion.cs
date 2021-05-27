namespace BlazorDemo.Configuration {
    public class DemoVersion : IDemoVersion {
        public string Version { get; }

        public DemoVersion(string version) {
            Version = version;
        }
}

    public interface IDemoVersion {
        string Version { get; }
    }
}
