using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.SalesSummary {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.SalesSummaryName;
            DisplayName = ReportNames.SalesSummary;
        }
    }
}
