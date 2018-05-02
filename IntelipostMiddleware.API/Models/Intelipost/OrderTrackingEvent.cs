﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.API.Models.Intelipost
{
    public sealed class OrderTrackingEvent
    {
        [JsonProperty(PropertyName = "status_id")]
        public int? Status_id { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }
    }
}
