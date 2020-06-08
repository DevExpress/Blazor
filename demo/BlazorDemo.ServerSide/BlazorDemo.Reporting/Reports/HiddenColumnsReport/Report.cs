using System;
using BlazorDemo.Reporting;
using Demo.Blazor.Reports.HiddenColumnsReport;
using DevExpress.Data.Entity;
using DevExpress.DataAccess.Native;
using DevExpress.XtraReports.UI;

namespace Demo.Blazor.Reports.HiddenColumnsReport {
    public partial class Report {
        public string ConnectionString { get; set; }
        public Report() {
            InitializeComponent();
            var objectDataSource = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource() { DataSourceType = typeof(VehiclesData.Vehicle) };
            DataSource = objectDataSource;
        }
    }
}
