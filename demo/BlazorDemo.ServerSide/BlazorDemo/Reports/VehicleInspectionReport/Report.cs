using System;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.VehicleInspectionReport {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.VehicleInspectionReportName;
            DisplayName = ReportNames.VehicleInspectionReport;
        }
        void Report_BeforePrint(object sender, PrintEventArgs e) {
            string language = parameterLanguage.Value as string;
            ApplyLocalization(language);
        }
    }
}
