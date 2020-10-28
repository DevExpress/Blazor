using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.BalanceSheetReport {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.BalanceSheetReportName;
            DisplayName = ReportNames.BalanceSheetReport;
        }
    }
}
