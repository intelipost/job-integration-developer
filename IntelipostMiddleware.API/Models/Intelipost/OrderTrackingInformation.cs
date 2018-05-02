using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntelipostMiddleware.API.Models.Intelipost
{
    public sealed class OrderTrackingInformation
    {
        [JsonProperty(PropertyName = "order_id")]
        public int? Order_id { get; set; }

        [JsonProperty(PropertyName = "event")]
        public OrderTrackingEvent Event { get; set; }

        [JsonProperty(PropertyName = "package")]
        public OrderTrackingPackage Package { get; set; }

    }
}
