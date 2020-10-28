using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.FormattingRules {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.FormattingRulesName;
            DisplayName = ReportNames.FormattingRules;
        }

        void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            UpdateFormattingRule();
        }
        void UpdateFormattingRule() {
            formattingRule1.Condition = (string)ConditionParameter.Value;
            formattingRule1.ApplyStyle(StyleSheet[(string)StyleParameter.Value]);
        }
    }
}
