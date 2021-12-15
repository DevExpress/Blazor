#if SERVER_BLAZOR
using System;
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
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next) {
            return ConfigureApp;

            void ConfigureApp(IApplicationBuilder app) {
                app.UseSession();
                app.UseDevExpressBlazorReporting();
                app.UseDevExpressServerSideBlazorReportViewer();
                DevExpress.DataAccess.DefaultConnectionStringProvider.AssignConnectionStrings(() => app.ApplicationServices.GetService<ReportingCustomConfigurationProvider>().GetGlobalConnectionStrings());

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
                services.AddScoped(serviceProvider => (IReportProvider)serviceProvider.GetRequiredService<ReportStorageWebExtension>());
                services.AddControllers(options => options.EnableEndpointRouting = false);
            });

        }
    }
}
#endif
