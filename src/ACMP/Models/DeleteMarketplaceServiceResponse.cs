using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceServiceResponse
    {
        [JsonPropertyName("Items")]
        public List<MarketplaceServiceInfo> Items { get; set; } = new();
    }
}
