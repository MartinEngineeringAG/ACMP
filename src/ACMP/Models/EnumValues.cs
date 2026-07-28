using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class EnumValues
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("Value")]
        public string? Value { get; set; }

        [JsonPropertyName("Hint")]
        public string? Hint { get; set; }
    }
}
