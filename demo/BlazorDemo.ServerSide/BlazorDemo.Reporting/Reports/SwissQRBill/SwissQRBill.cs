using System;
using System.Linq;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
using DevExpress.Data;

namespace Demo.Blazor.Reports.SwissQRBill {
    public partial class SwissQRBill {
        public SwissQRBill() {
            InitializeComponent();
        }

        protected override void OnBeforePrint(PrintEventArgs e) {
            var lang = Parameters.Cast<IParameter>().FirstOrDefault(a => a.Name == "Language");
            string language = lang.Value as string;
            ApplyLocalization(language);
            base.OnBeforePrint(e);
        }
    }
}
