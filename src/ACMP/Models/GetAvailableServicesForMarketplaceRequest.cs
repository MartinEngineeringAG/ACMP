using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetAvailableServicesForMarketplaceRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonPropertyName("filters")]
        public List<ServiceFilters>? Filters { get; set; }
    }
}
