using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.IListDataSource {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.HiddenColumnsName;
            DisplayName = ReportNames.HiddenColumns;
        }
    }
}
