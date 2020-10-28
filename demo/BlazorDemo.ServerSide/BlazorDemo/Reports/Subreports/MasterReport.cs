using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.Subreports {
    public partial class MasterReport {
        public MasterReport() {
            InitializeComponent();
            Name = ReportNames.SubreportsName;
            DisplayName = ReportNames.Subreports;
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(subreport1.ReportSource != null) {
                subreport1.ApplyParameterBindings();
                subreport1.ReportSource.ApplyFiltering();
                e.Cancel = subreport1.ReportSource.RowCount == 0;
            }
        }
        private void Report1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(subreport1.ReportSource != null)
                subreport1.ReportSource.FillDataSource();
        }
    }
}
