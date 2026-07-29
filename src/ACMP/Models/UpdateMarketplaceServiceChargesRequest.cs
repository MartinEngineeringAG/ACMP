using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateMarketplaceServiceChargesRequest
    {
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonPropertyName("marketplaceServiceInfo")]
        public List<MarketplaceServiceInfo>? MarketplaceServiceInfo { get; set; }
    }
}
