using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteAccountCustomActionRequestSubscriptionAccount
    {
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("Fields")]
        public ExecuteAccountCustomActionRequestSubscriptionAccountFields Fields { get; set; } = default!;

        [JsonPropertyName("ServiceName")]
        public string ServiceName { get; set; } = default!;
    }
}
