using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetAvailableServicesForMarketplaceRequest
    {
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonPropertyName("filters")]
        public List<ServiceFilters>? Filters { get; set; }
    }
}
