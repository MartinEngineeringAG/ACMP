using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleAdvancedSearchRequestSearchRequest
    {
        [JsonPropertyName("ParentAccountId")]
        public int? ParentAccountId { get; set; }

        [JsonPropertyName("AccountType")]
        public string? AccountType { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("ProductDisplayName")]
        public string? ProductDisplayName { get; set; }

        [JsonPropertyName("SearchField")]
        public SearchField? SearchField { get; set; }
    }
}
