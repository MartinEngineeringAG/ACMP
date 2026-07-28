using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class RetryLastFailedProvisioningRequest
    {
        /// <summary>
        /// Account ID of subscription
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }
    }
}
