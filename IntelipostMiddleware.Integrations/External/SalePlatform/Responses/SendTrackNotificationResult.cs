using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IntelipostMiddleware.Integrations.External.SalePlatform.Responses
{
    public class SendTrackNotificationResult : IntegrationProxyResult
    {
        public SendTrackNotificationResult(HttpResponseMessage message)
        {
            this.IsSuccess = message.IsSuccessStatusCode;
            var responseContent = message.Content;
            this.Message = responseContent.ReadAsStringAsync().Result;
        }
    }
}
