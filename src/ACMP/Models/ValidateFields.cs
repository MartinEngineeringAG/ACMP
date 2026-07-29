using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ValidateFields
    {
        [JsonPropertyName("subscriptionAccount")]
        public ValidateFieldsSubscriptionAccount SubscriptionAccount { get; set; } = default!;
    }
}
