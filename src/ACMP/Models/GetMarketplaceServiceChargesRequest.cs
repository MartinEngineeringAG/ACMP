using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetMarketplaceServiceChargesRequest
    {
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonPropertyName("filters")]
        public ServiceFilters? Filters { get; set; }
    }
}
