using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceServicesResponse
    {
        [JsonPropertyName("Items")]
        public List<MarketplaceServiceInfo> Items { get; set; } = new();
    }
}
