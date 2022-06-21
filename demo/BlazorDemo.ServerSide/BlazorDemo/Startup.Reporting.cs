#if SERVER_BLAZOR
using System;
using System.IO;
using System.Threading;
using BlazorDemo.Services;
using DevExpress.AspNetCore.Reporting;
using DevExpress.Blazor.Reporting;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Reporting {
    class StartupFilter : IStartupFilter {
        static Timer cleaner;
        static void Clean(string contentRootPath) {
            try {
                var reportsDirectory = Path.Join(contentRootPath, DemoReportStorageWebExtension.TempReportsFolderName);
                if(!Directory.Exists(reportsDirectory)) return;
                var directories = Directory.GetDirectories(reportsDirectory);
                foreach(var directory in directories) {
                    var files = Directory.GetFiles(directory);
                    foreach(var file in files) {
                        if(DateTime.UtcNow >= File.GetLastAccessTimeUtc(file).AddMinutes(10)) {
                            File.Delete(file);
                        }
                    }
                    if(Directory.GetFiles(directory).Length == 0) {
                        Directory.Delete(directory);
                    }
                }
            } catch { }
        }
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next) {
            return ConfigureApp;

            void ConfigureApp(IApplicationBuilder app) {
                app.UseSession();
                app.UseDevExpressBlazorReporting();
                app.UseDevExpressServerSideBlazorReportViewer();
                app.UseReporting(configurator => {
                    configurator.DesignAnalyzerOptions.EnableErrorCodeLinks = true;
                });
                DevExpress.DataAccess.DefaultConnectionStringProvider.AssignConnectionStrings(() => app.ApplicationServices.GetService<ReportingCustomConfigurationProvider>().GetGlobalConnectionStrings());
                var env = app.ApplicationServices.GetService<IWebHostEnvironment>();
                if(cleaner == null)
                    cleaner = new Timer(state => Clean((string)state), env.ContentRootPath, TimeSpan.Zero, TimeSpan.FromSeconds(30));
                next(app);
            }
        }
    }

    public sealed class ReportingHostingStartup {
        public static void Configure(IWebHostBuilder builder) {
            builder.ConfigureServices((webHostBuilderContext, services) => {
                var configurationProvider = new ReportingCustomConfigurationProvider(webHostBuilderContext.HostingEnvironment, webHostBuilderContext.Configuration);
                services.AddTransient<IStartupFilter, StartupFilter>();
                services.AddSession();
                services.AddDevExpressServerSideBlazorReportViewer();
                services.AddDevExpressBlazorReporting();
                services.AddSingleton<ReportingCustomConfigurationProvider, ReportingCustomConfigurationProvider>();
                services.ConfigureReportingServices((builder) => {
                    builder.UseAsyncEngine();
                    builder.DisableCheckForCustomControllers();
                    builder.ConfigureReportDesigner(designer => {
                        designer.RegisterDataSourceWizardConfigurationConnectionStringsProvider(configurationProvider.GetReportDesignerWizardConfigurationSection());
                    });
                    builder.ConfigureWebDocumentViewer(viewer => {
                        viewer.UseCachedReportSourceBuilder();
                    });
                });
                services.AddTransient<DevExpress.DataAccess.Wizard.Services.ICustomQueryValidator, DevExpress.DataAccess.Wizard.Services.CustomQueryValidator>();
                services.AddSingleton<IDemoReportSource, DemoReportSource>();
                services.AddScoped<ReportStorageWebExtension, DemoReportStorageWebExtension>();
                services.AddScoped(serviceProvider => (IReportProviderAsync)serviceProvider.GetRequiredService<ReportStorageWebExtension>());
                services.AddControllers(options => options.EnableEndpointRouting = false);
            });
        }
    }
}
#endif
