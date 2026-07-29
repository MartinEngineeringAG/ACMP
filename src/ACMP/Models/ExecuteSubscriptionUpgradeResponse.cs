using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteSubscriptionUpgradeResponse
    {
        [JsonPropertyName("Value")]
        public string Value { get; set; } = default!;
    }
}
