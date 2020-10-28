using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.SideBySideReports {
    public partial class EmployeeComparisonReport {
        public EmployeeComparisonReport() {
            InitializeComponent();
            Name = ReportNames.SideBySideReportsName;
            DisplayName = ReportNames.SideBySideReports;
        }
        protected override void OnDisposing() {
            DisposeReportSource(xrSubreport1);
            DisposeReportSource(xrSubreport2);
            base.OnDisposing();
        }
        void DisposeReportSource(XRSubreport subreport) {
            XtraReport report = subreport.ReportSource;
            if(report != null && !report.IsDisposed)
                report.Dispose();
        }
    }
}
