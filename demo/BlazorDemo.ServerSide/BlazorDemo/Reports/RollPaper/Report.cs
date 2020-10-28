using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.RollPaper {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.RollPaperName;
            DisplayName = ReportNames.RollPaper;
        }
    }
}
