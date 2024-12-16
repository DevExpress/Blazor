using System.ClientModel.Primitives;
using System.Net.Http;

namespace BlazorDemo.Services {
    //WA for https://github.com/Azure/azure-sdk-for-net/issues/45618
    class PromoteHttpStatusErrorsPipelineTransport : HttpClientPipelineTransport {
        protected override void OnReceivedResponse(PipelineMessage message, HttpResponseMessage httpResponse) {
            if(!httpResponse.IsSuccessStatusCode) {
                throw new HttpRequestException("HTTP request failed with status code: " + httpResponse.StatusCode);
            }
            base.OnReceivedResponse(message, httpResponse);
        }
    }
}
