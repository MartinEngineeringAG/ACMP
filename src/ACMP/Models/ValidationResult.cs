using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ValidationResult
    {
        [JsonPropertyName("Result")]
        public string? Result { get; set; }

        [JsonPropertyName("ErrorDetails")]
        public string? ErrorDetails { get; set; }

        [JsonPropertyName("FieldName")]
        public string? FieldName { get; set; }
    }
}
