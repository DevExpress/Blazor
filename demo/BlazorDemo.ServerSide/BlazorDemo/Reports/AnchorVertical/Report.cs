using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.AnchorVertical {
    public partial class Report {
        static Report() {
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(typeof(XtraReport), "Landscape", new DevExpress.XtraReports.Expressions.ExpressionBindingDescription(new[] { "BeforePrint" }, 1000, new string[0]));
        }
        public Report() {
            InitializeComponent();
            Name = ReportNames.AnchorName;
            DisplayName = ReportNames.Anchor;
            PrintingSystem.AfterMarginsChange += PrintingSystem_AfterMarginsChange;
            PrintingSystem.PageSettingsChanged += PrintingSystem_PageSettingsChanged;
        }
        void PrintingSystem_PageSettingsChanged(object sender, EventArgs e) {
            var ps = (PrintingSystemBase)sender;
            XtraPageSettingsBase pageSettings = ps.PageSettings;

            PaperKind = pageSettings.PaperKind;
            Landscape = pageSettings.Landscape;
            LandscapeParameter.Value = pageSettings.Landscape;

            CreateDocument();
        }
        void PrintingSystem_AfterMarginsChange(object sender, MarginsChangeEventArgs e) {
            switch(e.Side) {
                case MarginSide.Left:
                    Margins = new System.Drawing.Printing.Margins((int)e.Value, Margins.Right, Margins.Top, Margins.Bottom);
                    CreateDocument();
                    break;
                case MarginSide.Right:
                    Margins = new System.Drawing.Printing.Margins(Margins.Left, (int)e.Value, Margins.Top, Margins.Bottom);
                    CreateDocument();
                    break;
                case MarginSide.All:
                    Margins = ((PrintingSystemBase)sender).PageSettings.Margins;
                    CreateDocument();
                    break;
            }
        }
    }
}
