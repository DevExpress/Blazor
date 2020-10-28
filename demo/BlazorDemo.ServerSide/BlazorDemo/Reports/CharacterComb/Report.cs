using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.CharacterComb {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.CharacterCombName;
            DisplayName = ReportNames.CharacterComb;
        }
    }
}
