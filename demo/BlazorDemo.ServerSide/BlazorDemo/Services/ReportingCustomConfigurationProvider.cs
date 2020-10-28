#if NETCOREAPP3
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.Services {
    public class ReportingCustomConfigurationProvider {
        readonly IWebHostEnvironment hostingEnvironment;
        Dictionary<string, string> connectionStrings;

        public ReportingCustomConfigurationProvider(IWebHostEnvironment hostingEnvironment, IConfiguration config) {
            this.hostingEnvironment = hostingEnvironment;
            var dirPath = config.GetValue<string>("DataSourcesDir");
            connectionStrings = new Dictionary<string, string> {
                [$"ConnectionStrings:NWindConnectionString"] = $"XpoProvider=SQLite;Data Source={dirPath}nwind.db",
                [$"ConnectionStrings:VehiclesDBConnectionString"] = $"XpoProvider=SQLite;Data Source={dirPath}vehicles.db",
                [$"ConnectionStrings:HomesConnectionString"] = $"XpoProvider=SQLite;Data Source={dirPath}homes.db",
                [$"ConnectionStrings:ContactsConnectionString"] = $"XpoProvider=SQLite;Data Source={dirPath}Contacts.db",
                [$"ConnectionStrings:DevAvConnectionString"] = $"XpoProvider=SQLite;Data Source={dirPath}devav.sqlite3",
                [$"ConnectionStrings:CountriesConnectionString"] = $"XpoProvider=SQLite;Data Source={dirPath}Countries.db"
            };
        }
        public IDictionary<string, string> GetGlobalConnectionStrings() {
            return new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddInMemoryCollection(connectionStrings)
                .AddEnvironmentVariables()
                .Build()
                .GetSection("ConnectionStrings")
                .AsEnumerable(true)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        public IConfigurationSection GetReportDesignerWizardConfigurationSection() {
            return new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddInMemoryCollection(connectionStrings)
                .Build()
                .GetSection("ConnectionStrings");
        }
    }
}
#endif
