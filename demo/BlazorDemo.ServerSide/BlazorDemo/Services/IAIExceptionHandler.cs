using DevExpress.AIIntegration;
using System;

namespace BlazorDemo.Services {
    public class AIExceptionHandler : IAIExceptionHandler {
        public void ProcessException(AIExceptionArgs args) {
            if(!(args.Exception is AIDemoException))
                args.Exception = new Exception("Something went wrong.", args.Exception);
        }
    }
    //
    public class AIDemoException : Exception {
        public const string Error429Message = "You have reached demo request limit. Further requests are temporarily suspended. Please try again in a few minutes. Thank you for your patience and understanding.";
        public AIDemoException(string message) : base(message) {
        }
    }
}
