using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports.NorthwindTraders;

namespace BlazorDemo.Reports.NorthwindTraders {
    public partial class CatalogReport {
        public CatalogReport() {
            InitializeComponent();
            Name = BlazorDemo.Reports.ReportNames.NorthwindTraders_CatalogName;
            DisplayName = BlazorDemo.Reports.ReportNames.NorthwindTraders_Catalog;

            parameterSortGroupsType.Type = typeof(SortGroupsType);
            parameterSortGroupsType.Value = SortGroupsType.Count;
            parameterSortGroupsOrder.Type = typeof(XRColumnSortOrder);
            parameterSortGroupsOrder.Value = XRColumnSortOrder.Ascending;

            UpdateGroupSortingSummary();
        }

        void UpdateGroupSortingSummary() {
            GroupHeader1.SortingSummary.Enabled = true;
            GroupHeader1.SortingSummary.FieldName = "UnitPrice";
            GroupHeader1.SortingSummary.SortOrder = (XRColumnSortOrder)parameterSortGroupsOrder.Value;
            GroupHeader1.SortingSummary.IgnoreNullValues = true;

            switch((SortGroupsType)parameterSortGroupsType.Value) {
                case SortGroupsType.None:
                    GroupHeader1.SortingSummary.Enabled = false;
                    break;
                case SortGroupsType.Count:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Count;
                    break;
                case SortGroupsType.TotalSales:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Sum;
                    GroupHeader1.SortingSummary.FieldName = "ProductSales";
                    break;
                case SortGroupsType.LowestPrice:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Min;
                    break;
                case SortGroupsType.HighestPrice:
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Max;
                    break;
            }
        }
        protected override void OnBeforePrint(System.Drawing.Printing.PrintEventArgs e) {
            base.OnBeforePrint(e);
            UpdateGroupSortingSummary();
        }
    }
}
