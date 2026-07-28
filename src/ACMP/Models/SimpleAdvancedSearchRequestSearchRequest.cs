using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleAdvancedSearchRequestSearchRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100412</example>
        [JsonPropertyName("ParentAccountId")]
        public int? ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Product</example>
        [JsonPropertyName("AccountType")]
        public string? AccountType { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Child Svc</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>ProductNameSvc</example>
        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>ProductDisplaySvc</example>
        [JsonPropertyName("ProductDisplayName")]
        public string? ProductDisplayName { get; set; }

        [JsonPropertyName("SearchField")]
        public SearchField? SearchField { get; set; }
    }
}
