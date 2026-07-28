using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class MarketplaceInfo
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("Id")]
        public long? Id { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Simple Marketplace</example>
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>10</example>
        [JsonPropertyName("ServiceCount")]
        public long? ServiceCount { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("HiddenServiceCount")]
        public long? HiddenServiceCount { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>3</example>
        [JsonPropertyName("AssigneeCount")]
        public long? AssigneeCount { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("Priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>dynamic</example>
        [JsonPropertyName("PricingMode")]
        public string? PricingMode { get; set; }
    }
}
