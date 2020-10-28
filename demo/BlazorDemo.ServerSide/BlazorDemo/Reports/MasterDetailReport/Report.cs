using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.MasterDetailReport {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.MasterDetailReportName;
            DisplayName = ReportNames.MasterDetailReport;
        }
    }
}
