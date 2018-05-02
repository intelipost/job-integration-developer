using Newtonsoft.Json;

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
