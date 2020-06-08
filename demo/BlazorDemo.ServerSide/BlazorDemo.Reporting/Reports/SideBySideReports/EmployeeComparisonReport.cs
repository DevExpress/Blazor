using System;
using DevExpress.XtraReports.UI;

namespace Demo.Blazor.Reports.SideBySideReports
{
    public partial class EmployeeComparisonReport
    {
        public EmployeeComparisonReport()
        {
            InitializeComponent();
        }
        void DisposeReportSource(XRSubreport subreport) {
            XtraReport report = subreport.ReportSource;
            if(report != null && !report.IsDisposed)
                report.Dispose();
        }
        protected override void OnDisposing() {
            DisposeReportSource(xrSubreport1);
            DisposeReportSource(xrSubreport2);
            base.OnDisposing();
        }        
    }
}
