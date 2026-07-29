using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ListMarketplaceServicesRequest
    {
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }
    }
}
