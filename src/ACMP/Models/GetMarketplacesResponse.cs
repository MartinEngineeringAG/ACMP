using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetMarketplacesResponse
    {
        [JsonPropertyName("Items")]
        public List<MarketplaceInfo> Items { get; set; } = new();
    }
}
