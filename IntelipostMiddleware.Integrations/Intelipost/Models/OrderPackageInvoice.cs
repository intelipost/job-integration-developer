using Newtonsoft.Json;
using System;

namespace IntelipostMiddleware.Integrations.Intelipost.Models
{
    public sealed class OrderPackageInvoice
    {
        [JsonProperty(PropertyName = "number")]
        public string Mumber { get; set; }

        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "Date")]
        public DateTime Date { get; set; }
    }
}
