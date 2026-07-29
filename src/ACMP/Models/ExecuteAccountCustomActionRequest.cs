using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteAccountCustomActionRequest
    {
        [JsonPropertyName("action")]
        public string Action { get; set; } = default!;

        [JsonPropertyName("subscriptionAccount")]
        public ExecuteAccountCustomActionRequestSubscriptionAccount SubscriptionAccount { get; set; } = default!;
    }
}
