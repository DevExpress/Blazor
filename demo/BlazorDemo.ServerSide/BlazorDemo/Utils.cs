using Microsoft.Extensions.Configuration;

namespace BlazorDemo {
    class StaticAssetUtils {
        static string libraryPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        public static string GetContentPath(string assetPath) {
            return $"./_content/{libraryPath}/{assetPath}";
        }

        public static string GetImagePath(string imageFileName) {
            return GetContentPath($"images/{imageFileName}");
        }
    }

    public static class ConnectionStringUtils {

        public static string GetNorthwindConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
            return string.Format("Data Source={0}\\nwind.db", dirPath);
        }

        public static string GetIssuesConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
            return string.Format("Data Source={0}\\issue-list.db", dirPath);
        }

        public static string GetWorlcitiesConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
            return string.Format("Data Source={0}\\worldcities.db", dirPath);
        }

        public static string GetGridLargeDataConnectionString(IConfiguration config) {
            return GetConnectionString(config, "GridLargeDataConnectionString");
        }

        public static string GetPivotGridLargeDataConnectionString(IConfiguration config) {
            return GetConnectionString(config, "PivotGridLargeDataConnectionString");
        }

        static string GetConnectionString(IConfiguration config, string name) {
            var result = config.GetConnectionString(name);

            if(result == "{Remote demo database connection string}")
                return null;

            return result;
        }
    }
}

#if !SERVER_BLAZOR
namespace BlazorDemo.Reports { }
namespace BlazorDemo.Reporting.Reports { }
namespace DevExpress.Blazor.Reporting { }
namespace DevExpress.XtraReports.Web { }
namespace DevExpress.XtraReports.Web.WebDocumentViewer { }
namespace DevExpress.Blazor.RichEdit { }
#endif
