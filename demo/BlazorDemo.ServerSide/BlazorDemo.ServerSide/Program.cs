using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace BlazorDemo.ServerSide {
    public class Program {
        public static async Task Main(string[] args) {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) {

            return Host.CreateDefaultBuilder().ConfigureWebHostDefaults(Configure);
        }

        private static void Configure(IWebHostBuilder webHostBuilder) {
            webHostBuilder
                .UseConfiguration(
                    new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddIniFile("appsettings.ini", true)
                    .AddJsonFile("ConnectionStrings.json", optional: true, reloadOnChange: false)
                    .Build()
                )
                .ConfigureAppConfiguration(ConfigureAppDelegate)
                .ConfigureServices(ConfigureServices)
                .UseStaticWebAssets();



            static void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
                services.AddOptions();

                foreach (var moduleSection in GetModules(context).Select(x => context.Configuration.GetSection(x))) {
                    if (moduleSection.Exists())
                        services.Configure<SeoConfiguration>(moduleSection);
                }
            }

            static void ConfigureAppDelegate(WebHostBuilderContext context, IConfigurationBuilder commonBuilder) {
                foreach (var moduleName in GetModules(context))
                    commonBuilder.AddJsonFile($"{moduleName}Metadata.json", true, true);
            }

            static string[] GetModules(WebHostBuilderContext context) =>
                context.Configuration.GetValue<string>(WebHostDefaults.HostingStartupAssembliesKey).Split(';');
        }

    }
}