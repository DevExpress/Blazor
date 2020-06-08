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
                .ConfigureAppConfiguration(ConfigureAppDelegate)
                .UseStaticWebAssets();
            
            static void ConfigureAppDelegate(WebHostBuilderContext context, IConfigurationBuilder commonBuilder) {
                commonBuilder.AddJsonFile("SeoConfiguration.json", true, true);
            }
        }

    }
}