using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AccountFieldValueItem
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Ultimate answer</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Hint</example>
        [JsonPropertyName("Hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>43</example>
        [JsonPropertyName("Value")]
        public Dictionary<string, object?>? Value { get; set; }
    }
}
