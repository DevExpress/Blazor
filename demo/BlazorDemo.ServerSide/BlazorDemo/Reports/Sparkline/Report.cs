using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.Sparkline {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.SparklineName;
            DisplayName = ReportNames.Sparkline;
        }

        void sparkline_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            sparkline.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).Select(x => GetCurrentColumnValue<double>(x)).ToArray();
        }
    }
}
