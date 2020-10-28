using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.RestaurantMenu {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.RestaurantMenuName;
            DisplayName = ReportNames.RestaurantMenu;
        }
    }
}
