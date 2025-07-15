using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using DevExpress.XtraPrinting;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.Services {
    public class CustomPdfSignatureOptionsProviderAsync : DevExpress.XtraReports.Web.WebDocumentViewer.IPdfSignatureOptionsProviderAsync {
        readonly Dictionary<string, PdfSignatureOptions> signatures = new Dictionary<string, PdfSignatureOptions>();
        public CustomPdfSignatureOptionsProviderAsync(IConfiguration configuration) {
            var certificatePassword = configuration["ReportsSignatureDemoSettings:Password"];
            var outputDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string signatureDictionaryPath = Path.Combine(outputDir, "Signatures");
            signatures.Add(Guid.NewGuid().ToString(), new PdfSignatureOptions() {
                Certificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(Path.Combine(signatureDictionaryPath, "certificate.pfx"), certificatePassword),
                ContactInfo = "John Smith",
                Location = "Australia",
                Reason = "I Agree",
                ImageSource = DevExpress.XtraPrinting.Drawing.ImageSource.FromFile(Path.Combine(signatureDictionaryPath, "John_Smith.png"))
            });
            signatures.Add(Guid.NewGuid().ToString(), new PdfSignatureOptions() {
                Certificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(Path.Combine(signatureDictionaryPath, "certificate.pfx"), certificatePassword),
                ContactInfo = "Jane Cooper",
            });
        }

        public Task<Dictionary<string, PdfSignatureOptions>> GetAvailableOptionsAsync() {
            return Task.FromResult(signatures);
        }
    }
}
