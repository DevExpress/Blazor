using System;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace Demo.Blazor.Reports.VehicleInspectionReport {
    public partial class Report {
        public Report() {
            InitializeComponent();
        }
        void Report_BeforePrint(object sender, PrintEventArgs e) {
            string language = parameterLanguage.Value as string;
            ApplyLocalization(language);
        }
    }
}
