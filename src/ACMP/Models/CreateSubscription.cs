using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateSubscription
    {
        [JsonPropertyName("subscriptionAccount")]
        public CreateSubscriptionSubscriptionAccount SubscriptionAccount { get; set; } = default!;
    }
}
