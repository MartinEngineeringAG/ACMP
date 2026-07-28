using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceServicesRequest
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
        /// <example>["MyService1", "MyService2"]</example>
        [JsonPropertyName("serviceNames")]
        public Dictionary<string, object?> ServiceNames { get; set; } = default!;
    }
}
