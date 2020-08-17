using System;
using DevExpress.XtraReports.UI;

namespace Demo.Blazor.Reports.CachedDocumentSource {
    public partial class ReportWeb {
        public ReportWeb() {
            InitializeComponent();
            RowCountParameter.Value = 2500u;
        }
    }
}
