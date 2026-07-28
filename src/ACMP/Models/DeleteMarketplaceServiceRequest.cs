using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceServiceRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("marketplaceId")]
        public long MarketplaceId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>MyService</example>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; } = default!;
    }
}
