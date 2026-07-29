using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetAvailableServicesForMarketplaceResponse
    {
        [JsonPropertyName("Items")]
        public List<SimpleProductInfo> Items { get; set; } = new();
    }
}
