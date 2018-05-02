using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IntelipostMiddleware.Integrations.External.SalePlatform.Responses;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using Newtonsoft.Json;

namespace IntelipostMiddleware.Integrations.External.SalePlatform
{
    public sealed class SalePlatformProxy : IIntegrationProxy
    {
        private async Task<object> teste(OrderTrackingInformation orderTrackingInformation)
        {
            return await HttpRequestHelper.Post("http://localhost:50502/api/tracking", orderTrackingInformation);
        }


        public SendTrackNotificationResult SendTrackNotification(OrderTrackingInformation orderTrackingInformation)
        {
            Task t = this.teste(orderTrackingInformation);

            return new SendTrackNotificationResult();
        }
    }


}
