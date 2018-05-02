using Newtonsoft.Json;
using System;

namespace IntelipostMiddleware.Integrations.Intelipost.Models
{
    public sealed class OrderTrackingEvent
    {
        [JsonProperty(PropertyName = "status_id")]
        public int? Status_id { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }
    }
}
