using System;
using DevExpress.XtraReports.UI;

namespace Demo.Blazor.Reports.FormattingRules {
    public partial class Report {
        public Report() {
            InitializeComponent();
        }

        void UpdateFormattingRule() {
            formattingRule1.Condition = (string)ConditionParameter.Value;
            formattingRule1.ApplyStyle(StyleSheet[(string)StyleParameter.Value]);
        }

        private void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            UpdateFormattingRule();
        }
    }
}
