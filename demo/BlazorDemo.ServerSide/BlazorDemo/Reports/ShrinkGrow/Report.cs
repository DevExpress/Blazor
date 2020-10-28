using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.ShrinkGrow {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.ShrinkGrowName;
            DisplayName = ReportNames.ShrinkGrow;
        }
    }
}
