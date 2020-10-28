using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.CachedDocumentSource {
    public partial class ReportWeb {
        public ReportWeb() {
            InitializeComponent();
            Name = ReportNames.LargeDatasetName;
            DisplayName = ReportNames.LargeDataset;
            RowCountParameter.Value = 2500u;
        }
    }
}
