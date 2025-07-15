using System;
using DevExpress.Blazor.Reporting.Services;
using DevExpress.XtraReports.Web.ReportDesigner.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace BlazorDemo.Services {
    public class AIReportDesignerExceptionHandler : ReportDesignerExceptionHandler {
        public override string GetUnknownExceptionMessage(Exception ex) {
            if(ex is AIDemoException) {
                return ex.Message;
            }
            return base.GetUnknownExceptionMessage(ex);
        }
    }

    public class AIWebDocumentViewerExceptionHandler : WebDocumentViewerExceptionHandler {
        public override string GetUnknownExceptionMessage(Exception ex) {
            if(ex is AIDemoException) {
                return ex.Message;
            }
            return base.GetUnknownExceptionMessage(ex);
        }
    }

    public class AIReportViewerErrorNotifier : IErrorNotifier {
        public event Action<string> OnErrorMessage = (message) => { };

        public void ProcessError(Exception exception) {
            OnErrorMessage.Invoke(exception.Message == AIDemoException.Error429Message ? exception.Message: "Internal Server Error");
        }
    }
}
