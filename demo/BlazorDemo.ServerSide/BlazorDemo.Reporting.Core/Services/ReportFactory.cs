using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;

namespace BlazorDemo.Services {
    public interface IDemoReportSource {
        XtraReport GetReport(string reportName);
        Dictionary<string, string> GetReportList();
    }

    public class ReportInfo {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool ShouldLoadFont { get; set; }
        public Func<XtraReport> CreateAction { get; set; }
    }

    public class DemoReportSource : IDemoReportSource {
        readonly protected List<ReportInfo> commonReports = new() {
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.DrillDown, Name = XtraReportsDemos.ReportNames.DrillDownName, CreateAction = () => new XtraReportsDemos.DrillDownReport.DrillDownReport() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.DrillThrough, Name = XtraReportsDemos.ReportNames.DrillThroughName, CreateAction = () => new XtraReportsDemos.DrillThroughReport.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.EmployeePerformanceReview, Name = XtraReportsDemos.ReportNames.EmployeePerformanceReviewName, CreateAction = () => new XtraReportsDemos.EmployeePerformanceReview.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.VehicleInspectionReport, Name = XtraReportsDemos.ReportNames.VehicleInspectionReportName, CreateAction = () => new XtraReportsDemos.VehicleInspectionReport.Report() },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.HierarchicalReport, Name = XtraReportsDemos.ReportNames.HierarchicalReportName, CreateAction = () => new XtraReportsDemos.HierarchicalReport.Report(), ShouldLoadFont = true },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.TableReport, Name = XtraReportsDemos.ReportNames.TableReportName, CreateAction = () => new XtraReportsDemos.TableReport.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.MasterDetailReport, Name = XtraReportsDemos.ReportNames.MasterDetailReportName, CreateAction = () => new XtraReportsDemos.MasterDetailReport.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.Subreports, Name = XtraReportsDemos.ReportNames.SubreportsName, CreateAction = () => new XtraReportsDemos.Subreports.MasterReport() },            
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.ReportMergingWithPdf, Name = XtraReportsDemos.ReportNames.ReportMergingWithPdfName, CreateAction = () => new XtraReportsDemos.ReportMergingWithPdf.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.EmbeddedPDFContent, Name = XtraReportsDemos.ReportNames.EmbeddedPDFContentName, CreateAction = () => new XtraReportsDemos.EmbeddedPDFContent.Invoice() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.SideBySideReports, Name = XtraReportsDemos.ReportNames.SideBySideReportsName, CreateAction = () => new XtraReportsDemos.SideBySideReports.EmployeeComparisonReport() },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.BalanceSheetReport, Name = XtraReportsDemos.ReportNames.BalanceSheetReportName, CreateAction = () => new XtraReportsDemos.BalanceSheetReport.Report(), ShouldLoadFont = true },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.NorthwindTraders_Invoice, Name = XtraReportsDemos.ReportNames.NorthwindTraders_InvoiceName, CreateAction = () => new XtraReportsDemos.NorthwindTraders.InvoiceReport() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.ProfitAndLoss, Name = XtraReportsDemos.ReportNames.ProfitAndLossName, CreateAction = () => new XtraReportsDemos.ProfitAndLossReport.Report(), ShouldLoadFont = true },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.BarCodes_BarcodeTypes, Name = XtraReportsDemos.ReportNames.BarCodes_BarcodeTypesName, CreateAction = () => new XtraReportsDemos.BarCodes.BarCodeTypesReport() },
            //new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.Shape, Name = XtraReportsDemos.ReportNames.ShapeName, CreateAction = () => new Reports.Shape.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.Chart, Name = XtraReportsDemos.ReportNames.ChartName, CreateAction = () => new XtraReportsDemos.Charts.Report() },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.CharacterComb, Name = XtraReportsDemos.ReportNames.CharacterCombName, CreateAction = () => new XtraReportsDemos.CharacterComb.Report() },
            
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.CalculatedFields, Name = XtraReportsDemos.ReportNames.CalculatedFieldsName, CreateAction = () => new XtraReportsDemos.CalculatedFieldsReport.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.MailMerge, Name = XtraReportsDemos.ReportNames.MailMergeName, CreateAction = () => new XtraReportsDemos.MailMerge.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.MultiColumn, Name = XtraReportsDemos.ReportNames.MultiColumnName, CreateAction = () => new XtraReportsDemos.MultiColumnReport.Report(), ShouldLoadFont = true },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.NorthwindTraders_Products, Name = XtraReportsDemos.ReportNames.NorthwindTraders_ProductsName, CreateAction = () => new XtraReportsDemos.NorthwindTraders.ProductListReport() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.NorthwindTraders_Catalog, Name = XtraReportsDemos.ReportNames.NorthwindTraders_CatalogName, CreateAction = () => new XtraReportsDemos.NorthwindTraders.CatalogReport() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.ShrinkGrow, Name = XtraReportsDemos.ReportNames.ShrinkGrowName, CreateAction = () => new XtraReportsDemos.ShrinkGrow.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.Anchor, Name = XtraReportsDemos.ReportNames.AnchorName, CreateAction = () => new XtraReportsDemos.AnchorVertical.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.HiddenColumns, Name = XtraReportsDemos.ReportNames.HiddenColumnsName, CreateAction = () => new XtraReportsDemos.IListDatasource.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.SalesSummary, Name = XtraReportsDemos.ReportNames.SalesSummaryName, CreateAction = () => new XtraReportsDemos.SalesSummary.Report() },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.Sparkline, Name = XtraReportsDemos.ReportNames.SparklineName, CreateAction = () => new XtraReportsDemos.Sparkline.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.CrossBands, Name = XtraReportsDemos.ReportNames.CrossBandsName, CreateAction = () => new XtraReportsDemos.CrossBandControls.Report() },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.ProductLabels, Name = XtraReportsDemos.ReportNames.ProductLabelsName, CreateAction = () => new XtraReportsDemos.BarCodes.ProductLabelsReport() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.ReportMerging, Name = XtraReportsDemos.ReportNames.ReportMergingName, CreateAction = () => new XtraReportsDemos.ReportMerging.MergedReport() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.InteractiveSorting, Name = XtraReportsDemos.ReportNames.InteractiveSortingName, CreateAction = () => new XtraReportsDemos.InteractiveSorting.Report() },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.PivotGridAndChart, Name = XtraReportsDemos.ReportNames.PivotGridAndChartName, CreateAction = () => new XtraReportsDemos.PivotGridAndChart.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.LargeDataset, Name = XtraReportsDemos.ReportNames.LargeDatasetName, CreateAction = () => new XtraReportsDemos.CachedDocumentSourceReport.ReportWeb(), ShouldLoadFont = true },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.LargeDataset, Name = XtraReportsDemos.ReportNames.LargeDatasetName + 100, CreateAction = () => new XtraReportsDemos.CachedDocumentSourceReport.ReportWeb(100u), ShouldLoadFont = true },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.SwissQRBill, Name = XtraReportsDemos.ReportNames.SwissQRBillName, CreateAction = () => new XtraReportsDemos.SwissQRCode.SwissQRBill(), ShouldLoadFont = true },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.RollPaper, Name = XtraReportsDemos.ReportNames.RollPaperName, CreateAction = () => new XtraReportsDemos.RollPaper.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.RestaurantMenu, Name = XtraReportsDemos.ReportNames.RestaurantMenuName, CreateAction = () => new XtraReportsDemos.RestaurantMenu.Report(), ShouldLoadFont = true },

            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.CrossBandContent, Name = XtraReportsDemos.ReportNames.CrossBandContentName, CreateAction = () => new XtraReportsDemos.CrossBandContent.Report() },
            new ReportInfo() { DisplayName = XtraReportsDemos.ReportNames.PdfVisualSignature, Name = XtraReportsDemos.ReportNames.PdfVisualSignatureName, CreateAction = () => new XtraReportsDemos.PdfVisualSignature.Report() },
        };

        public Dictionary<string, string> GetReportList() {
            return commonReports.OrderBy(x => x.DisplayName).ToDictionary(i => i.Name, i => i.DisplayName);
        }

        public XtraReport GetReport(string reportName) {
            return commonReports.FirstOrDefault(x => x.Name == reportName)?.CreateAction();
        }
    }

    public class DemoReportSourceWasm : DemoReportSource, IReportProviderAsync {
#pragma warning disable DX0006
        readonly HttpClient httpClient;

        public DemoReportSourceWasm(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
#pragma warning restore DX0006

        public async Task<XtraReport> GetReportAsync(string reportName, ReportProviderContext context) {
            var shouldRequestFont = commonReports.FirstOrDefault(x => x.Name == reportName)?.ShouldLoadFont;
            if (shouldRequestFont.Value) {
                await ReportingFontLoader.LoadFonts(httpClient, "arial");
            }
            return GetReport(reportName);
        }
    }
}
