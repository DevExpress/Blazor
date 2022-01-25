#if SERVER_BLAZOR
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;

namespace BlazorDemo.Services {
    public class DemoReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension, IReportProviderAsync {
        public static string TempReportsFolderName => Path.Join("obj", "UserReports");
        public const string IdCookieKey = "xrId";
        string TempReportsFolderPath => Path.Join(webHostEnvironment.ContentRootPath, TempReportsFolderName);
        protected IHttpContextAccessor httpContextAccessor { get; }
        protected IDemoReportSource PredefinedReports { get; }
        protected IWebHostEnvironment webHostEnvironment { get; }
        IJSRuntime jsRuntime { get; }

        public DemoReportStorageWebExtension(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment, IJSRuntime jsRuntime, IDemoReportSource reportFactory) {
            this.httpContextAccessor = httpContextAccessor;
            this.webHostEnvironment = webHostEnvironment;
            PredefinedReports = reportFactory;
            this.jsRuntime = jsRuntime;
        }

        async Task<string> GetGuidAsync() {
            string xrId = string.Empty;
            httpContextAccessor.HttpContext?.Request.Cookies.TryGetValue(IdCookieKey, out xrId);
            if(string.IsNullOrEmpty(xrId)) {
                xrId = await jsRuntime.InvokeAsync<string>("_dx_demoPageHelper.getCookie", IdCookieKey);
                if(string.IsNullOrEmpty(xrId)) {
                    xrId = Guid.NewGuid().ToString("N");
                    await jsRuntime.InvokeAsync<string>("_dxr_setId", IdCookieKey, xrId);
                }
            }
            return xrId;
        }

        public async Task<string> GetReportFolderPathAsync() {
            var folderPath = Path.Join(TempReportsFolderPath, await GetGuidAsync());
            if(!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
            }
            return folderPath;
        }

        public override bool CanSetData(string reportName) {
            return true;
        }

        public override bool IsValidUrl(string reportName) {
            if(string.IsNullOrEmpty(reportName))
                return false;
            else if(reportName.Any(x => Array.IndexOf(Path.GetInvalidFileNameChars(), x) >= 0))
                return false;
            else if(reportName.Contains(".."))
                return false;
            return true;
        }

        public override async Task<byte[]> GetDataAsync(string reportName) {
            ValidateReportName(reportName);
            var reportPath = Path.Join(await GetReportFolderPathAsync(), reportName + ".repx");
            if(File.Exists(reportPath)) return await File.ReadAllBytesAsync(reportPath);
            XtraReport report = PredefinedReports.GetReport(reportName);
            if(report == null) {
                throw new Exception("Report was not found.");
            }
            using(MemoryStream ms = new MemoryStream()) {
                report.SaveLayoutToXml(ms);
                return ms.ToArray();
            }
        }

        async Task<XtraReport> IReportProviderAsync.GetReportAsync(string id, ReportProviderContext context) {
            ValidateReportName(id);
            var reportPath = Path.Join(await GetReportFolderPathAsync(), id + ".repx");
            if(File.Exists(reportPath)) {
                return XtraReport.FromFile(reportPath);
            }
            var report = PredefinedReports.GetReport(id);
            if(report == null)
                throw new Exception("Report not found.");
            return report;
        }

        public override async Task<Dictionary<string, string>> GetUrlsAsync() {
            var predefinedList = PredefinedReports.GetReportList();
            if(Directory.Exists(await GetReportFolderPathAsync())) {
                var files = Directory.GetFiles(await GetReportFolderPathAsync()).Select(x => Path.GetFileNameWithoutExtension(x)).Where(x => !predefinedList.ContainsKey(x));
                foreach(var fileName in files) {
                    predefinedList.Add(fileName, fileName);
                }
            }
            return predefinedList;
        }

        public override async Task SetDataAsync(XtraReport report, string url) {
            ValidateReportName(url);
            report.SaveLayoutToXml(Path.Join(await GetReportFolderPathAsync(), url + ".repx"));
        }

        public override async Task<string> SetNewDataAsync(XtraReport report, string defaultUrl) {
            ValidateReportName(defaultUrl);
            report.SaveLayoutToXml(Path.Join(await GetReportFolderPathAsync(), defaultUrl + ".repx"));
            return defaultUrl;
        }

        void ValidateReportName(string reportName) {
            if(!IsValidUrl(reportName))
                throw new InvalidOperationException("Invalid name");
        }
    }
}
#endif
