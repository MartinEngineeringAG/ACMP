using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateMarketplaceRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>My new markeplace</example>
        [JsonPropertyName("marketplaceName")]
        public string? MarketplaceName { get; set; }
    }
}
