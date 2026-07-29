using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSubscriptionDependenciesResponse
    {
        [JsonPropertyName("Items")]
        public List<Subscription> Items { get; set; } = new();
    }
}
