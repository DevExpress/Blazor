using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.HierarchicalReport {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.HierarchicalReportName;
            DisplayName = ReportNames.HierarchicalReport;
        }
    }
}
