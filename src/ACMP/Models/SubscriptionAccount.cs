using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionAccount
    {
        [JsonPropertyName("subscriptionAccount")]
        public SubscriptionAccountSubscriptionAccount SubscriptionAccountPayload { get; set; } = default!;
    }
}
