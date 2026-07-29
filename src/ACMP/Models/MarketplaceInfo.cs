using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class MarketplaceInfo
    {
        [JsonPropertyName("Id")]
        public long? Id { get; set; }

        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("ServiceCount")]
        public long? ServiceCount { get; set; }

        [JsonPropertyName("HiddenServiceCount")]
        public long? HiddenServiceCount { get; set; }

        [JsonPropertyName("AssigneeCount")]
        public long? AssigneeCount { get; set; }

        [JsonPropertyName("Priority")]
        public long? Priority { get; set; }

        [JsonPropertyName("PricingMode")]
        public string? PricingMode { get; set; }
    }
}
