using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.NorthwindTraders {
    public partial class ProductListReport {
        public ProductListReport() {
            InitializeComponent();
            Name = ReportNames.NorthwindTraders_ProductsName;
            DisplayName = ReportNames.NorthwindTraders_Products;
        }
    }
}
