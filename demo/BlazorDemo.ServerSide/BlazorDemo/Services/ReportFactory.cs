using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemo.Reports;
using DevExpress.XtraReports.UI;

namespace BlazorDemo.Services {
    public interface IDemoReportSource {
        XtraReport GetReport(string reportName);
        Dictionary<string, string> GetReportList();
    }

    public class ReportInfo {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Func<XtraReport> CreateAction { get; set; }
    }

    public class DemoReportSource : IDemoReportSource {
        List<ReportInfo> predefinedReports = new List<ReportInfo> {
            new ReportInfo() { DisplayName = ReportNames.DrillDown, Name = ReportNames.DrillDownName, CreateAction = () => new Reports.DrillDown.Report() },
            new ReportInfo() { DisplayName = ReportNames.EmployeePerformanceReview, Name = ReportNames.EmployeePerformanceReviewName, CreateAction = () => new Reports.EmployeePerformanceReview.Report() },
            new ReportInfo() { DisplayName = ReportNames.InteractiveSorting, Name = ReportNames.InteractiveSortingName, CreateAction = () => new Reports.InteractiveSorting.Report() },
            new ReportInfo() { DisplayName = ReportNames.CharacterComb, Name = ReportNames.CharacterCombName, CreateAction = () => new Reports.CharacterComb.Report() },
            new ReportInfo() { DisplayName = ReportNames.VehicleInspectionReport, Name = ReportNames.VehicleInspectionReportName, CreateAction = () => new Reports.VehicleInspectionReport.Report() },

            new ReportInfo() { DisplayName = ReportNames.HierarchicalReport, Name = ReportNames.HierarchicalReportName, CreateAction = () => new Reports.HierarchicalReport.Report() },
            new ReportInfo() { DisplayName = ReportNames.TableReport, Name = ReportNames.TableReportName, CreateAction = () => new Reports.TableReport.Report() },
            new ReportInfo() { DisplayName = ReportNames.MasterDetailReport, Name = ReportNames.MasterDetailReportName, CreateAction = () => new Reports.MasterDetailReport.Report() },
            new ReportInfo() { DisplayName = ReportNames.Subreports, Name = ReportNames.SubreportsName, CreateAction = () => new Reports.Subreports.MasterReport() },
            new ReportInfo() { DisplayName = ReportNames.MultiColumn, Name = ReportNames.MultiColumnName, CreateAction = () => new Reports.MultiColumnReport.Report() },
            new ReportInfo() { DisplayName = ReportNames.ProductLabels, Name = ReportNames.ProductLabelsName, CreateAction = () => new Reports.BarCodes.ProductLabelsReport() },
            new ReportInfo() { DisplayName = ReportNames.ReportMerging, Name = ReportNames.ReportMergingName, CreateAction = () => new Reports.ReportMerging.MergedReport() },
            new ReportInfo() { DisplayName = ReportNames.ReportMergingWithPdf, Name = ReportNames.ReportMergingWithPdfName, CreateAction = () => new Reports.ReportMergingWithPdf.Report() },
            new ReportInfo() { DisplayName = ReportNames.SideBySideReports, Name = ReportNames.SideBySideReportsName, CreateAction = () => new Reports.SideBySideReports.EmployeeComparisonReport() },

            new ReportInfo() { DisplayName = ReportNames.PivotGridAndChart, Name = ReportNames.PivotGridAndChartName, CreateAction = () => new Reports.PivotGridAndChart.Report() },
            new ReportInfo() { DisplayName = ReportNames.CalculatedFields, Name = ReportNames.CalculatedFieldsName, CreateAction = () => new Reports.CalculatedFields.Report() },
            new ReportInfo() { DisplayName = ReportNames.LargeDataset, Name = ReportNames.LargeDatasetName, CreateAction = () => new Reports.CachedDocumentSource.ReportWeb() },
            new ReportInfo() { DisplayName = ReportNames.MailMerge, Name = ReportNames.MailMergeName, CreateAction = () => new Reports.MailMerge.Report() },

            new ReportInfo() { DisplayName = ReportNames.BalanceSheetReport, Name = ReportNames.BalanceSheetReportName, CreateAction = () => new Reports.BalanceSheetReport.Report() },
            new ReportInfo() { DisplayName = ReportNames.NorthwindTraders_Products, Name = ReportNames.NorthwindTraders_ProductsName, CreateAction = () => new Reports.NorthwindTraders.ProductListReport() },
            new ReportInfo() { DisplayName = ReportNames.NorthwindTraders_Catalog, Name = ReportNames.NorthwindTraders_CatalogName, CreateAction = () => new Reports.NorthwindTraders.CatalogReport() },
            new ReportInfo() { DisplayName = ReportNames.NorthwindTraders_Invoice, Name = ReportNames.NorthwindTraders_InvoiceName, CreateAction = () => new Reports.NorthwindTraders.InvoiceReport() },
            new ReportInfo() { DisplayName = ReportNames.SwissQRBill, Name = ReportNames.SwissQRBillName, CreateAction = () => new Reports.SwissQRBill.SwissQRBill() },
            new ReportInfo() { DisplayName = ReportNames.ProfitAndLoss, Name = ReportNames.ProfitAndLossName, CreateAction = () => new Reports.ProfitAndLoss.Report() },
            new ReportInfo() { DisplayName = ReportNames.RollPaper, Name = ReportNames.RollPaperName, CreateAction = () => new Reports.RollPaper.Report() },
            new ReportInfo() { DisplayName = ReportNames.RestaurantMenu, Name = ReportNames.RestaurantMenuName, CreateAction = () => new Reports.RestaurantMenu.Report() },
            new ReportInfo() { DisplayName = ReportNames.SalesSummary, Name = ReportNames.SalesSummaryName, CreateAction = () => new Reports.SalesSummary.Report() },

            new ReportInfo() { DisplayName = ReportNames.CrossBandContent, Name = ReportNames.CrossBandContentName, CreateAction = () => new Reports.CrossBandContent.Report() },
            new ReportInfo() { DisplayName = ReportNames.ShrinkGrow, Name = ReportNames.ShrinkGrowName, CreateAction = () => new Reports.ShrinkGrow.Report() },
            new ReportInfo() { DisplayName = ReportNames.Anchor, Name = ReportNames.AnchorName, CreateAction = () => new Reports.AnchorVertical.Report() },
            new ReportInfo() { DisplayName = ReportNames.HiddenColumns, Name = ReportNames.HiddenColumnsName, CreateAction = () => new Reports.IListDataSource.Report() },

            new ReportInfo() { DisplayName = ReportNames.Sparkline, Name = ReportNames.SparklineName, CreateAction = () => new Reports.Sparkline.Report() },
            new ReportInfo() { DisplayName = ReportNames.BarCodes_BarcodeTypes, Name = ReportNames.BarCodes_BarcodeTypesName, CreateAction = () => new Reports.BarCodes.BarCodeTypesReport() },
            new ReportInfo() { DisplayName = ReportNames.PdfSignature, Name = ReportNames.PdfSignatureName, CreateAction = () => new Reports.PdfVisualSignature.Report() },
            new ReportInfo() { DisplayName = ReportNames.Shape, Name = ReportNames.ShapeName, CreateAction = () => new Reports.Shape.Report() },
            new ReportInfo() { DisplayName = ReportNames.Chart, Name = ReportNames.ChartName, CreateAction = () => new Reports.Charts.Report() },
            new ReportInfo() { DisplayName = ReportNames.CrossBands, Name = ReportNames.CrossBandsName, CreateAction = () => new Reports.CrossBandControls.Report() },
        };

        public Dictionary<string, string> GetReportList() {
            return predefinedReports.ToDictionary(i => i.Name, i => i.DisplayName);
        }

        public XtraReport GetReport(string reportName) {
            return predefinedReports.FirstOrDefault(x => x.Name == reportName)?.CreateAction();
        }
    }
}
