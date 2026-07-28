using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteSubscriptionUpgradeResponse
    {
        /// <summary>
        /// Value returned by the endpoint.
        /// </summary>
        /// <example>a68f6d81-7c14-4c40-9566-1e4de4add0e9</example>
        [JsonPropertyName("Value")]
        public string Value { get; set; } = default!;
    }
}
