using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetProductFieldsForUpgradeRequest
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("targetProductName")]
        public string TargetProductName { get; set; } = default!;
    }
}
