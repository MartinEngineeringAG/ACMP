using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ServiceFilters
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>[100001, 100003]</example>
        [JsonPropertyName("OwnerAccountIds")]
        public List<long>? OwnerAccountIds { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>["firstCategory", "secondCategory"]</example>
        [JsonPropertyName("ServiceCategories")]
        public List<string>? ServiceCategories { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>["firstTag", "secondTag"]</example>
        [JsonPropertyName("ServiceTags")]
        public List<string>? ServiceTags { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>["firstServiceGroup", "secondServiceGroup"]</example>
        [JsonPropertyName("ServiceGroups")]
        public List<string>? ServiceGroups { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>[1, 2]</example>
        [JsonPropertyName("PriceableItemIds")]
        public List<long>? PriceableItemIds { get; set; }
    }
}
