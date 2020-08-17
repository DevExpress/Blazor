using System;
using DevExpress.XtraReports.UI;

namespace Demo.Blazor.Reports.BarCodes {
    public partial class BarCodeTypesReport {
        static BarCodeTypesReport() {
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(typeof(XRBarCode), "AutoModule", new DevExpress.XtraReports.Expressions.ExpressionBindingDescription(new[] { "BeforePrint" }, 1000, new string[0]));
        }

        public BarCodeTypesReport() {
            InitializeComponent();
        }
    }
}
