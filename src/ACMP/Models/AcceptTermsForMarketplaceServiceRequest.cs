using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AcceptTermsForMarketplaceServiceRequest
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
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;
    }
}
