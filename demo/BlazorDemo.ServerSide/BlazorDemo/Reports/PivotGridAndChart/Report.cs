using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;
using BlazorDemo.Reports.PivotGridAndChart;

namespace BlazorDemo.Reports.PivotGridAndChart {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.PivotGridAndChartName;
            DisplayName = ReportNames.PivotGridAndChart;
            parameterViewType.Type = typeof(ViewTypeFiltered);
            parameterViewType.Value = ViewTypeFiltered.StackedSplineArea;
            this.BeforePrint += Report_BeforePrint;
        }

        private void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            xrChart.BeginInit();
            xrChart.SeriesTemplate.ChangeView((ViewType)parameterViewType.Value);
            bool labelsVisible = Convert.ToBoolean(parameterShowLabels.Value);
            xrChart.SeriesTemplate.LabelsVisibility = labelsVisible ? DefaultBoolean.True : DefaultBoolean.False;
            var diagram = xrChart.Diagram as Diagram3D;
            if(diagram != null && !labelsVisible) {
                diagram.ZoomPercent = 190;
                diagram.VerticalScrollPercent = 5;
            }
            xrPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = Convert.ToBoolean(parameterShowRowGrandTotals.Value);
            xrPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = Convert.ToBoolean(parameterShowColumnGrandTotals.Value);
            xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = Convert.ToBoolean(parameterGenerateSeriesFromColumns.Value);
            xrChart.EndInit();
        }
    }
}
