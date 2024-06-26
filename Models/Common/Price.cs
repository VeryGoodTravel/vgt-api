﻿using Newtonsoft.Json;

namespace vgt_api.Models.Common
{
    public class Price
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}
