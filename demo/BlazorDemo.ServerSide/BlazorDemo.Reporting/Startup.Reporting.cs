using System;
using System.Collections.Generic;
using System.IO;
using BlazorDemo.Reporting;
using Demo.Blazor.Services;
using DevExpress.AspNetCore.Reporting;
using DevExpress.Blazor.Reporting;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly:HostingStartup(typeof(ReportingHostingStartup))]
namespace BlazorDemo.Reporting {
    class StartupFilter : IStartupFilter {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next) {
            return ConfigureApp;

            void ConfigureApp(IApplicationBuilder app) {
                var loggerFactory = app.ApplicationServices.GetService<ILoggerFactory>();
                var reportingLogger = loggerFactory.CreateLogger("DXBlazorReporting");
                DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize((exception, message) => {
                    var logMessage = $"[{DateTime.Now}]: Exception occurred. Message: '{message}'. Exception Details:\r\n{exception}";
                    reportingLogger.LogError(logMessage);
                });

                app.UseSession();
                app.UseDevExpressBlazorReporting();
                DevExpress.DataAccess.DefaultConnectionStringProvider.AssignConnectionStrings(() => app.ApplicationServices.GetService<ReportingCustomConfigurationProvider>().GetGlobalConnectionStrings());
                
                next(app);
            }
        }
    }

    sealed class ReportingHostingStartup : IHostingStartup {
        void IHostingStartup.Configure(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(((context, configurationBuilder) =>
            {
                var dictionary = new Dictionary<string, string>
                {
                    ["DataSourcesDir"] = Path.Combine(System.AppContext.BaseDirectory, "DataSources/")
                };
                configurationBuilder.AddInMemoryCollection(dictionary);
            }));
            builder.ConfigureServices((webHostBuilderContext, services) => {
                var configurationProvider = new ReportingCustomConfigurationProvider(webHostBuilderContext.HostingEnvironment, webHostBuilderContext.Configuration);
                services.AddTransient<IStartupFilter, StartupFilter>();
                services.AddSession();
                services.AddDevExpressBlazorReporting();
                services.AddSingleton<ReportingCustomConfigurationProvider, ReportingCustomConfigurationProvider>();
                services.AddSingleton<WebDocumentViewerOperationLogger, DocumentViewerOperationInterceptor>();
                services.ConfigureReportingServices((builder) => {
                    builder.ConfigureReportDesigner(designer => {
                        designer.RegisterDataSourceWizardConfigurationConnectionStringsProvider(configurationProvider.GetReportDesignerWizardConfigurationSection());
                    });
                    builder.ConfigureWebDocumentViewer(viewer => {
                        viewer.UseCachedReportSourceBuilder();
                    });
                });
                services.AddSingleton<IDemoReportSource, DemoReportSource>();
                services.AddScoped<ReportStorageWebExtension, DemoReportStorageWebExtension>();

                services.AddControllers(options => options.EnableEndpointRouting = false);
            });

        }
    }
}