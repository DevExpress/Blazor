namespace BlazorDemo.Reports {
    public class ReportNames {
        public static string GenerateUrl(string reportName) {
            return $"DocumentViewer/{reportName}";
        }
        public static string GeneraterReportViewerUrl(string reportName) {
            return $"ReportViewer/{reportName}";
        }
    }
}
