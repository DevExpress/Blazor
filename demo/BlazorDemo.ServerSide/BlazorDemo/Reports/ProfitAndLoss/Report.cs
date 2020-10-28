using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.ProfitAndLoss {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.ProfitAndLossName;
            DisplayName = ReportNames.ProfitAndLoss;
        }
    }
}
