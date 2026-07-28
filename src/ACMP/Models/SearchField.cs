using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SearchField
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>fvgbhnj</example>
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>demo</example>
        [JsonPropertyName("Value")]
        public string? Value { get; set; }
    }
}
