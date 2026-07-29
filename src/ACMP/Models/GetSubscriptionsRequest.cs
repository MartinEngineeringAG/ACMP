using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSubscriptionsRequest
    {
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }

        [JsonPropertyName("excludeUserLevel")]
        public bool? ExcludeUserLevel { get; set; }
    }
}
