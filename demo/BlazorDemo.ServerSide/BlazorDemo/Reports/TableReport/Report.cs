using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.TableReport {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.TableReportName;
            DisplayName = ReportNames.TableReport;
        }
    }
}
