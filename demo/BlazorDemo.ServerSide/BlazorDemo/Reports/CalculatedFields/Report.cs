using System.Drawing.Printing;
using System.Linq;
using DevExpress.XtraReports.Parameters;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.CalculatedFields {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.CalculatedFieldsName;
            DisplayName = ReportNames.CalculatedFields;
        }

        private void Report_BeforePrint(object sender, PrintEventArgs e) {
            UpdateReportCalculatedField();
        }
        void UpdateReportCalculatedField() {
            string columnDescription = GetDescription((StaticListLookUpSettings)ExpressionParameter.LookUpSettings, (string)ExpressionParameter.Value);
            string expressionValue = (string)ExpressionParameter.Value;
            SetReportParameters(columnDescription, expressionValue);
        }
        void SetReportParameters(string columnDescription, string expression) {
            calculatedField1.Expression = expression;
            xrTableCell12.Text = columnDescription;
            xrLabel3.TextFormatString = "Total " + columnDescription + " - {0:c}";
            xrLabel3.XlsxFormatString = @"""Total " + columnDescription + @" - ""$0.00";
        }
        static string GetDescription(StaticListLookUpSettings lookupSettings, string value) {
            LookUpValue lookup = lookupSettings.LookUpValues.FirstOrDefault(x => (string)x.Value == value);
            return lookup != null ? lookup.Description : "";
        }
    }
}
