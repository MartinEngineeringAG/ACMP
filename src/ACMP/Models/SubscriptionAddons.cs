using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class SubscriptionAddons
    {
        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("AccountState")]
        public AccountState? AccountState { get; set; }

        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }
    }
}
