using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleAdvancedSearchResult
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
        /// <example>Jane Smith</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Email</example>
        [JsonPropertyName("Field")]
        public string? Field { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>jane.smith@example.com</example>
        [JsonPropertyName("FieldValue")]
        public string? FieldValue { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>AdvancedPlus</example>
        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Advanced Savings Account</example>
        [JsonPropertyName("ProductDisplayName")]
        public string? ProductDisplayName { get; set; }
    }
}
