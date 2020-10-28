using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.MailMerge {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.MailMergeName;
            DisplayName = ReportNames.MailMerge;
        }
    }
}
