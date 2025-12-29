using System;
using System.ClientModel.Primitives;
using System.Linq;
using System.Net.Http;
using System.Threading;

namespace BlazorDemo.Services {
    //WA for https://github.com/Azure/azure-sdk-for-net/issues/45618

    public class PromoteHttpStatusErrorsPipelineMessage : PipelineMessage {
        CancellationTokenSource cts = new CancellationTokenSource();
        public PromoteHttpStatusErrorsPipelineMessage(PipelineRequest request) : base(request) {
            CancellationToken = cts.Token;
        }
        public void Cancel() => cts.Cancel();
    }
    public class PromoteHttpStatusErrorsPipelineTransport : HttpClientPipelineTransport {
        private readonly AIHttpResponseProcessor processor;
        public PromoteHttpStatusErrorsPipelineTransport(AIHttpResponseProcessor processor) : base() {
            this.processor = processor;
        }
        protected override PipelineMessage CreateMessageCore() {
            var message = base.CreateMessageCore();
            return new PromoteHttpStatusErrorsPipelineMessage(message.Request);
        }
        protected override void OnReceivedResponse(PipelineMessage message, HttpResponseMessage httpResponse) {
            if(!httpResponse.IsSuccessStatusCode && (int)httpResponse.StatusCode == 429) {
                processor.Process(message, httpResponse.Headers.GetValues("Retry-After").FirstOrDefault());
            }
            base.OnReceivedResponse(message, httpResponse);
        }
    }

    public class AIHttpResponseProcessor {
        public event Action<PromoteHttpStatusErrorsPipelineMessage, string> OnProcess;

        public void Process(PipelineMessage message, string waitingTime) {
            OnProcess?.Invoke(message as PromoteHttpStatusErrorsPipelineMessage, waitingTime);
        }
    }
}
