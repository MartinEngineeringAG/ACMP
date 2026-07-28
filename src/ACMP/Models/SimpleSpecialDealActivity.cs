using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealActivity
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>admin@example.com</example>
        [JsonPropertyName("Author")]
        public string? Author { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Deal activated for customer</example>
        [JsonPropertyName("Comments")]
        public string? Comments { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2026-01-03T11:22:33.456</example>
        [JsonPropertyName("CreatedDate")]
        public DateTimeOffset? CreatedDate { get; set; }
    }
}
