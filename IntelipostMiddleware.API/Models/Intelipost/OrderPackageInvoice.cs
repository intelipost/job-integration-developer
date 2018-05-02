using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.API.Models.Intelipost
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
