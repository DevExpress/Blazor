using System.Drawing;
using System.Linq;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace Demo.Blazor.Reports.Charts {
    public partial class Report {

        public Report() {
            InitializeComponent();
            xrChart6.BeforePrint += Chart6_BeforePrint;
            xrChart1.CustomDrawSeries += Chart1_CustomDrawSeries;
            xrChart3.CustomDrawSeriesPoint += Chart1_CustomDrawSeries;
        }

        private void Chart6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            Color color = xrChart3.PaletteRepository["Palette 1"][DetailReport2.CurrentRowIndex].Color;
            xrChart6.PaletteRepository["Palette 1"][0].Color = color;

            xrChart6.Series[0].Points.BeginUpdate();
            xrChart6.Series[0].Points.Clear();
            var categorySales = DetailReport2.GetCurrentColumnValue<long>("Sales");
            var totalSales = DetailReport2.GetCurrentColumnValue<decimal>("TotalSales");
            var otherSales = totalSales - categorySales;
            xrChart6.Series[0].Points.Add(new SeriesPoint("Category Sales", categorySales));
            xrChart6.Series[0].Points.Add(new SeriesPoint("Other Sales", otherSales));
            xrChart6.Series[0].Points.EndUpdate();

            var percentageOfSales = categorySales / totalSales;
            ((DoughnutSeriesView)xrChart6.Series[0].View).TotalLabel.TextPattern = string.Format("{0:0%}", percentageOfSales);
            ((DoughnutSeriesView)xrChart6.Series[0].View).TotalLabel.TextColor = color;
        }

        private void Chart1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgsBase e) {
            var markerImage = new Bitmap(e.LegendMarkerSize.Width, e.LegendMarkerSize.Height);
            using(var gr = Graphics.FromImage(markerImage)) {
                gr.Clear(e.LegendDrawOptions.Color);
            }
            e.LegendMarkerImage = markerImage;
        }
    }
}
