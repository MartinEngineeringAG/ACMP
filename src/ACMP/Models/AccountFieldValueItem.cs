using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AccountFieldValueItem
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("Hint")]
        public string? Hint { get; set; }

        [JsonPropertyName("Value")]
        public Dictionary<string, object?>? Value { get; set; }
    }
}
