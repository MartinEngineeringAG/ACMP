using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ValidationResult
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>FAILED</example>
        [JsonPropertyName("Result")]
        public string? Result { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>"Accept only *.jpg and *.pdf files"</example>
        [JsonPropertyName("ErrorDetails")]
        public string? ErrorDetails { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Verification</example>
        [JsonPropertyName("FieldName")]
        public string? FieldName { get; set; }
    }
}
