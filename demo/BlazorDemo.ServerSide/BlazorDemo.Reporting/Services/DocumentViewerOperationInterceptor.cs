using System;
using Demo.Blazor.Reports.HiddenColumnsReport;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.Native.Data;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace Demo.Blazor.Services {
    public class DocumentViewerOperationInterceptor : WebDocumentViewerOperationLogger {
        ReportingCustomConfigurationProvider ReportingCustomConfigurationProvider { get; }
        public DocumentViewerOperationInterceptor(ReportingCustomConfigurationProvider reportingCustomConfigurationProvider) {
            ReportingCustomConfigurationProvider = reportingCustomConfigurationProvider;
        }

        public override Action BuildStarting(string reportId, string reportUrl, XtraReport report, ReportBuildProperties buildProperties) {
            var dse = new UniqueDataSourceEnumerator();
            foreach(var dataSource in dse.EnumerateDataSources(report, true)) {
                if(dataSource is ObjectDataSource ods && ods.DataSource is Type dataSourceType && dataSourceType == typeof(VehiclesData.Vehicle)) {
                    report.DataSource = new ObjectDataSource() {
                        DataSource = new VehiclesData(ReportingCustomConfigurationProvider.GetGlobalConnectionStrings()["VehiclesConnection"]),
                        DataMember = nameof(VehiclesData.GetVehicles)
                    };
                }
            }

            return base.BuildStarting(reportId, reportUrl, report, buildProperties);
        }
    }
}
