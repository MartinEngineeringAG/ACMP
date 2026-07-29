using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionInputDefinition
    {
        [JsonPropertyName("Fields")]
        public List<AccountField>? Fields { get; set; }

        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }
    }
}
