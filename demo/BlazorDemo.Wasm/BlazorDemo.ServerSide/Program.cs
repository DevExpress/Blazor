using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorDemo.ServerSide {
    public class Program {
        public static async Task Main(string[] args) {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) {

            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(Configure);
        }

        private static void Configure(IWebHostBuilder webHostBuilder) {
            webHostBuilder
                .UseConfiguration(
                    new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddIniFile("appsettings.ini", true)
                    .AddJsonFile("ConnectionStrings.json", false, false)
                    .Build()
                )
                .ConfigureAppConfiguration(ConfigureAppDelegate)
                .ConfigureServices(ConfigureServices)
                .UseStaticWebAssets();



            static void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
                services.AddOptions();

                foreach(var moduleSection in GetModules(context).Select(x => context.Configuration.GetSection(x))) {
                    if(moduleSection.Exists())
                        services.Configure<SeoConfiguration>(moduleSection);
                }
            }

            static void ConfigureAppDelegate(WebHostBuilderContext context, IConfigurationBuilder commonBuilder) {
                foreach(var moduleName in GetModules(context))
                    commonBuilder.AddJsonFile($"{moduleName}Metadata.json", true, true);
            }

            static string[] GetModules(WebHostBuilderContext context) =>
                context.Configuration.GetValue<string>(WebHostDefaults.HostingStartupAssembliesKey).Split(';');
        }

    }
}
