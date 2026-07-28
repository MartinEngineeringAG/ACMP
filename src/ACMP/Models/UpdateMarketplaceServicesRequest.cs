using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateMarketplaceServicesRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("marketplaceOfferId")]
        public long? MarketplaceOfferId { get; set; }

        [JsonPropertyName("services")]
        public List<MarketplaceServiceInfo>? Services { get; set; }
    }
}
