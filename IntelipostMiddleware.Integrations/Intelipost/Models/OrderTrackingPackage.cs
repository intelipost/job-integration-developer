using Newtonsoft.Json;

namespace IntelipostMiddleware.Integrations.Intelipost.Models
{
    public sealed class OrderTrackingPackage
    {
        [JsonProperty(PropertyName = "package_id")]
        public int Package_id { get; set; }

        [JsonProperty(PropertyName = "package_invoice")]
        public OrderPackageInvoice Package_invoice { get; set; }
    }
}
