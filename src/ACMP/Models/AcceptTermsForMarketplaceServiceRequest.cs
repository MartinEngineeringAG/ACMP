using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AcceptTermsForMarketplaceServiceRequest
    {
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;
    }
}
