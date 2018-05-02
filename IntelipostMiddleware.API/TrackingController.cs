using IntelipostMiddleware.Integrations.External;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using static IntelipostMiddleware.Integrations.External.IntegrationProxyArgs;

namespace IntelipostMiddleware.API
{
    [Route("api/[controller]")]
    public class TrackingController : Controller
    {
        [HttpGet]
        public string Get()
        {
            OrderTrackingInformation info = new OrderTrackingInformation();
            info.Order_id = 2;
            info.Event = new OrderTrackingEvent
            {
                Date = DateTime.Now,
                Status_id = 1
            };
            info.Package = new OrderTrackingPackage
            {
                Package_id = 12,
                Package_invoice = new OrderPackageInvoice
                {
                    Date = DateTime.Now,
                    Key = "323",
                    Mumber = "342"
                }
            };
            
            var xy = 
            IntegrationProxy.GetInstance(new IntegrationProxyArgsBuilder().BuildDefault())
                .Proxy.SendTrackNotification(info);

            
            return Ok("alo").ToString();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OrderTrackingInformation value)
        {
            TrackingValidationManager validator = new TrackingValidationManager(this, value);
            if (!validator.Validate(this.ModelState))
            {
                return this.BadRequest(this.ModelState);
            }

            var result = IntegrationProxy.GetInstance(new IntegrationProxyArgsBuilder().BuildDefault())
                .Proxy.SendTrackNotification(value);

            if (!result.IsSuccess)
            {
                return this.BadRequest(result.Message);
            }

            return this.Ok();
        }        
    }
}
