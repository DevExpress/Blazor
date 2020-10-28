using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.NorthwindTraders {
    public partial class InvoiceReport {
        public InvoiceReport() {
            InitializeComponent();
            Name = ReportNames.NorthwindTraders_InvoiceName;
            DisplayName = ReportNames.NorthwindTraders_Invoice;
        }
    }
}
