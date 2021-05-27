#if SERVER_BLAZOR
using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BlazorDemo.Services {
    public static class SessionExtensions {
        public static void SetObjectAsJson(this ISession session, string key, object value) {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key) {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class DemoReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension {
        readonly static string ReportExtensionSessionKey = "dxReportStorageWebExtensionKey_1C5CB325-69FA-4C9E-9D4D-96AE00C3E86E";
        protected IHttpContextAccessor HttpContextAccessor { get; }
        protected IDemoReportSource PredefinedReports { get; }
        protected ISession Session { get { return HttpContextAccessor.HttpContext.Session; } }
        readonly object sync = new object();

        public DemoReportStorageWebExtension(IHttpContextAccessor httpContextAccessor, IDemoReportSource reportFactory) {
            HttpContextAccessor = httpContextAccessor;
            PredefinedReports = reportFactory;
        }

        public override bool CanSetData(string reportName) {
            return true;
        }

        public override bool IsValidUrl(string reportName) {
            return true;
        }

        public override byte[] GetData(string reportName) {
            byte[] reportBytes;
            lock(sync) {
                var storedReports = Session.GetObjectFromJson<Dictionary<string, string>>(ReportExtensionSessionKey);
                if(storedReports != null && storedReports.ContainsKey(reportName) && Session.TryGetValue(reportName, out reportBytes)) {
                    return reportBytes;
                }
            }
            XtraReport report = PredefinedReports.GetReport(reportName);
            if(report == null) {
                throw new Exception("Report was not found.");
            }

            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                report.Dispose();
                return stream.ToArray();
            }
        }

        public override Dictionary<string, string> GetUrls() {
            var predefinedList = PredefinedReports.GetReportList();
            var reportListFromSession = Session.GetObjectFromJson<Dictionary<string, string>>(ReportExtensionSessionKey);
            if(reportListFromSession != null)
                foreach(var reportItem in reportListFromSession) {
                    predefinedList[reportItem.Key] = reportItem.Value;
                }
            return predefinedList;
        }

        public override void SetData(XtraReport report, string reportName) {
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                SaveAndUpateSessionState(reportName, stream.ToArray());
            }
        }

        public override string SetNewData(XtraReport report, string defaultReportName) {
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                SaveAndUpateSessionState(defaultReportName, stream.ToArray());
            }
            return defaultReportName;
        }

        void SaveAndUpateSessionState(string reportName, byte[] reportLayout) {
            lock(sync) {
                var reports = Session.GetObjectFromJson<Dictionary<string, string>>(ReportExtensionSessionKey);
                if(reports == null)
                    reports = new Dictionary<string, string>();
                if(!reports.ContainsKey(reportName))
                    reports.Add(reportName, reportName);
                Session.SetObjectAsJson(ReportExtensionSessionKey, reports);
                Session.Set(reportName, reportLayout);
            }
        }

    }
}
#endif
