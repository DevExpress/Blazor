using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using BlazorDemo.Data;
using BlazorDemo.Data.Issues;
using BlazorDemo.Pages.TreeList;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo {
    class StaticAssetUtils {
        static string libraryPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        public static string GetContentPath(string assetPath) {
#pragma warning disable DX0025 // not a path, but url
            return $"./_content/{libraryPath}/{assetPath}";
#pragma warning restore DX0025
        }

        public static string GetImagePath(string imageFileName) {
#pragma warning disable DX0025 // not a path, but url
            return GetContentPath($"images/{imageFileName}");
#pragma warning restore DX0025
        }

        public static string GetEmployeeImagePath(string employeeId) {
            return GetImagePath($"employees/item-template{employeeId}.jpg");
        }

        public static string GetEmployeeImagePath(int employeeId) {
            return GetEmployeeImagePath(employeeId.ToString());
        }
    }

    public static class ConnectionStringUtils {

        public static string GetNorthwindConnectionString(IConfiguration config) {
            return GetConnectionString(config, "NorthwindConnectionString");
        }
        public static string GetNorthwindSqliteConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
#pragma warning disable DX0025 // parameter is passed from configuration
            return $"Data Source={Path.Combine(dirPath, "nwind.db")}";
#pragma warning restore DX0025
        }
        public static string GetHomesSqliteConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
#pragma warning disable DX0025 // parameter is passed from configuration
            return $"Data Source={Path.Combine(dirPath, "homes.db")}";
#pragma warning restore DX0025
        }

        public static string GetIssuesConnectionString(IConfiguration config) {
            return GetConnectionString(config, "IssuesConnectionString");
        }
        public static string GetIssuesSqliteConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
#pragma warning disable DX0025 // parameter is passed from configuration
            return $"Data Source={Path.Combine(dirPath, "issue-list.db")}";
#pragma warning restore DX0025
        }

        public static string GetWorlcitiesConnectionString(IConfiguration config) {
            return GetConnectionString(config, "WorldcitiesConnectionString");
        }
        public static string GetWorlcitiesSqliteConnectionString(IConfiguration config) {
            var dirPath = config.GetValue<string>("DataSourcesFolder");
#pragma warning disable DX0025 // parameter is passed from configuration
            return $"Data Source={Path.Combine(dirPath, "worldcities.db")}";
#pragma warning restore DX0025
        }

        public static string GetGridLargeDataConnectionString(IConfiguration config) {
            return GetConnectionString(config, "GridLargeDataConnectionString");
        }

        public static string GetVehiclesXmlDataSourcePath(IConfiguration config) {
            return Path.Combine(config.GetValue<string>("DataSourcesFolder"), "Vehicles.xml");
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

    public static class DemoRenderUtils {
        private const string ExcludedPageSectionsQueryParameter = "excludedPageSections";

        public static bool PreventRenderDemoSection(string uri, string demoSectionId) {
            var queryString = (new Uri(uri)).Query;
            var queryCollection = HttpUtility.ParseQueryString(queryString);
            var excludedDemos = queryCollection.Get(ExcludedPageSectionsQueryParameter);
            if(!string.IsNullOrEmpty(excludedDemos) && excludedDemos.Split(',').Contains(demoSectionId)) {
                return true;
            }

            return false;
        }

        public static string CombineCssClasses(params string[] value) => CombineCssClasses((IEnumerable<string>)value);
        public static string CombineCssClasses(IEnumerable<string> value) {
            var cssClass = string.Join(" ", value.Where(v => !string.IsNullOrWhiteSpace(v))).Trim();
            return string.IsNullOrWhiteSpace(cssClass) ? null : cssClass;
        }
    }

    public static class SplitTextHelper {
        public static string SplitPascalCaseString(string name) {
            string[] separateWordsByCapitalLetter = System.Text.RegularExpressions.Regex.Split(name, @"(?<!^)(?=[A-Z])");
            return String.Join(" ", separateWordsByCapitalLetter);
        }
    }

    public static class DemoTemplateIconUtils {
        public static MarkupString GetEmployeeTaskPriorityIconHtml(EmployeeTask employeeTask) {
            var displayText = EmployeeTask.EmployeeTaskPriorityToString(employeeTask);
            var badgeClass = employeeTask.Priority switch {
                -1 => "bg-success",
                0 => "bg-info",
                1 => "bg-warning",
                _ => throw new ArgumentException()
            };

            string html = string.Format("<span class='badge {0} py-1 px-2' title='{1} priority'>{1}</span>", badgeClass, displayText);
            return new MarkupString(html);
        }

        public static MarkupString GetIssueStatusIconHtml(IssueStatus status) {
            string statusIconName = status switch {
                IssueStatus.Fixed => "fixed",
                IssueStatus.Postponed => "postponed",
                IssueStatus.Rejected => "rejected",
                IssueStatus.New => "new",
                _ => throw new NotSupportedException()
            };

            string html = string.Format("<span class='status-icon status-icon-{0} me-1 rounded-circle d-inline-block'></span>", statusIconName);
            return new MarkupString(html);
        }

        public static MarkupString GetIssuePriorityIconHtml(IssuePriority priority) {
            string priorityClass = "warning";
            string title = "Medium";
            if(priority == IssuePriority.High) {
                priorityClass = "danger";
                title = "High";
            }
            if(priority == IssuePriority.Low) {
                priorityClass = "info";
                title = "Low";
            }
            string html = string.Format("<span class='badge priority-{0} py-1 px-2' title='{1} Priority'>{1}</span>", priorityClass, title);
            return new MarkupString(html);
        }

        public static MarkupString GetIssueTypeIconHtml(IssueType type) {
            string html = "";
            if(type == IssueType.Bug)
                html = "<span class='bug-icon d-inline-block me-1' title='Bug'></span>";
            return new MarkupString(html);
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

