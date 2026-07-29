using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateSubscription
    {
        [JsonPropertyName("subscription")]
        public UpdateSubscriptionSubscription Subscription { get; set; } = default!;
    }
}
