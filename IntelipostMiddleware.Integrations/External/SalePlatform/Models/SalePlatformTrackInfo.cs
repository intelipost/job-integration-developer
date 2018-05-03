using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IntelipostMiddleware.Integrations.External.SalePlatform.Models
{
    public sealed class SalePlatformTrackInfo
    {
        [DataMember(Name = "orderId")]
        public int OrderId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
    }
}
