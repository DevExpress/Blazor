using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using DevExpress.AspNetCore.Reporting.ReportDesigner;
using DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ReportDesigner;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Reports {
    public class CustomWebDocumentViewerController : WebDocumentViewerController {
        public CustomWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService) {
        }
    }

    public class CustomReportDesignerController : ReportDesignerController {
        public CustomReportDesignerController(IReportDesignerMvcControllerService controllerService) : base(controllerService) {
        }

        [HttpPost("[action]")]
        public async Task<object> GetReportDesignerModel(
            [FromForm] string reportUrl,
            [FromForm] ReportDesignerSettingsBase designerModelSettings,
            [FromServices] IReportDesignerClientSideModelGenerator designerClientSideModelGenerator) {
            ReportDesignerModel model;
            Dictionary<string, object> dataSources = new();
            if(string.IsNullOrEmpty(reportUrl))
                model = await designerClientSideModelGenerator.GetModelAsync(new XtraReport(), dataSources, "/DXXRD", "/DXXRDV", "/DXXQB");
            else
                model = await designerClientSideModelGenerator.GetModelAsync(reportUrl, dataSources, "/DXXRD", "/DXXRDV", "/DXXQB");
            model.Assign(designerModelSettings);
            var modelJsonScript = designerClientSideModelGenerator.GetJsonModelScript(model);
            return Content(modelJsonScript, "application/json");
        }
    }

    public class CustomQueryBuilderController : QueryBuilderController {
        public CustomQueryBuilderController(IQueryBuilderMvcControllerService controllerService) : base(controllerService) {
        }
    }
}
