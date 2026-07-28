using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSubscriptionsRequest
    {
        /// <summary>
        /// The parent Account ID.
        /// </summary>
        /// <example>12345</example>
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// Should be removed from payload if not used.The reseller context Account ID. Used to determine subscription priceable items purchase price. This parameter is optional, if not set, default value is set to method callers reseller account."
        /// </summary>
        /// <example>34567</example>
        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }

        /// <summary>
        /// If set to true then user level subscriptions are excluded from result. If not set then all subscriptions are returned.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("excludeUserLevel")]
        public bool? ExcludeUserLevel { get; set; }
    }
}
