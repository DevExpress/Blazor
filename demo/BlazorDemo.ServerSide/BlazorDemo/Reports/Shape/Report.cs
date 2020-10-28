using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.Shape {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.ShapeName;
            DisplayName = ReportNames.Shape;
        }
    }
}
