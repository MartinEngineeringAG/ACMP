using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSubscriptionDependenciesRequest
    {
        /// <summary>
        /// The parent Account ID.
        /// </summary>
        /// <example>12345</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// Should be removed from payload if not used.The reseller context Account ID. Used to determine subscription priceable items purchase price. This parameter is optional, if not set, default value is set to method callers reseller account."
        /// </summary>
        /// <example>34567</example>
        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }
    }
}
