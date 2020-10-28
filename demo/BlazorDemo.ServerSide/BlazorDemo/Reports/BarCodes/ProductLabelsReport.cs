using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.BarCodes {
    public partial class ProductLabelsReport {
        public ProductLabelsReport() {
            InitializeComponent();
            Name = ReportNames.BarCodes_ProductLabelsName;
            DisplayName = ReportNames.BarCodes_ProductLabels;
        }
    }
}
