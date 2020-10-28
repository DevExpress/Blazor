using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.CustomDraw {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.CustomDrawName;
            DisplayName = ReportNames.CustomDraw;
        }
        public int RegionID { get { return (int)RegionIdParameter.Value; } }

        private void Population_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            //UpdateControls();
        }
        //void UpdateControls()
        //{
        //    using (var entities = new CountriesEntities())
        //    {
        //        var regions = (from region in entities.AboutRegions
        //                       where region.Id == RegionID
        //                       select region).ToList();
        //        xrLabel1.Text = regions.First().Region;
        //        customControl1.UpdateData(regions);
        //    }
        //}
    }
}
