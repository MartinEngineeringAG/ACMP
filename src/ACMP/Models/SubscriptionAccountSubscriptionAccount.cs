using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionAccountSubscriptionAccount
    {
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("Fields")]
        public SubscriptionAccountSubscriptionAccountFields Fields { get; set; } = default!;

        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("ServiceName")]
        public string ServiceName { get; set; } = default!;

        [JsonPropertyName("Action")]
        public string? Action { get; set; }
    }
}
