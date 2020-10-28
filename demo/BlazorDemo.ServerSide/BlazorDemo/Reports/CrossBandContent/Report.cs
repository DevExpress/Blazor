using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.CrossBandContent {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.CrossBandContentName;
            DisplayName = ReportNames.CrossBandContent;
        }
    }
}
