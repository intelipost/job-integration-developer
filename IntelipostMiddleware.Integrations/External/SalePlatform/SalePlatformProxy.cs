using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IntelipostMiddleware.Integrations.External.SalePlatform.Adapters;
using IntelipostMiddleware.Integrations.External.SalePlatform.Responses;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using Newtonsoft.Json;

namespace IntelipostMiddleware.Integrations.External.SalePlatform
{
    public sealed class SalePlatformProxy : IPlatformProxy
    {
        public SendTrackNotificationResult SendTrackNotification(OrderTrackingInformation orderTrackingInformation)
        {
            OrderTrackingInfoAdapter adaptee = new OrderTrackingInfoAdapter();
            
            using (var client = new HttpClient())
            {
                /*
                 * Autenticacao pode ser feita aqui
                 */ 
                var url = "http://localhost:50502/api/saleplatform";
                var response = client.PostAsync(url, new JsonContent(adaptee.Adapt(orderTrackingInformation))).Result;

                return new SendTrackNotificationResult(response);
            }
        }

        public class JsonContent : StringContent
        {
            public JsonContent(object value) : base(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json")
            {
            }
        }
    }


}
