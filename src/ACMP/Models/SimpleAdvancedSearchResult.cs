using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleAdvancedSearchResult
    {
        [JsonPropertyName("AccountId")]
        public int? AccountId { get; set; }

        [JsonPropertyName("AccountType")]
        public string? AccountType { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("Field")]
        public string? Field { get; set; }

        [JsonPropertyName("FieldValue")]
        public string? FieldValue { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("ProductDisplayName")]
        public string? ProductDisplayName { get; set; }
    }
}
