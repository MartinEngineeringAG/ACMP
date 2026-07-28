using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSearchResponse
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>12345</example>
        [JsonPropertyName("AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Product</example>
        [JsonPropertyName("AccountType")]
        public string? AccountType { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>John Doe</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>PremiumAccount</example>
        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Active</example>
        [JsonPropertyName("AccountState")]
        public string? AccountState { get; set; }
    }
}
