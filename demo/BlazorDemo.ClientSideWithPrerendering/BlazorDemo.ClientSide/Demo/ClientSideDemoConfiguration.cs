using Microsoft.Extensions.Options;

namespace Demo.Blazor {
    public class ClientSideDemoConfiguration : IOptions<DemoConfiguration> {
        static DemoConfiguration DemoConfiguration = new DemoConfiguration() { SiteMode = false };
        public DemoConfiguration Value => DemoConfiguration;
    }
}