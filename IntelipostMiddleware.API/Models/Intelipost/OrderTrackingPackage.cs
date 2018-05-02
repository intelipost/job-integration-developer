using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.API.Models.Intelipost
{
    public sealed class OrderTrackingPackage
    {
        [JsonProperty(PropertyName = "package_id")]
        public int Package_id { get; set; }

        [JsonProperty(PropertyName = "package_invoice")]
        public OrderPackageInvoice Package_invoice { get; set; }
    }
}
