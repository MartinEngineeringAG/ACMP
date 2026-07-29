using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceServicesRequest
    {
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonPropertyName("serviceNames")]
        public Dictionary<string, object?> ServiceNames { get; set; } = default!;
    }
}
