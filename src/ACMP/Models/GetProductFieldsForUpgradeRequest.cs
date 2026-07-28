using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetProductFieldsForUpgradeRequest
    {
        /// <summary>
        /// Account id of the account which should be upgraded.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// Technical product name of destination account
        /// </summary>
        /// <example>1429492_NCEMicros365E3_12907</example>
        [JsonPropertyName("targetProductName")]
        public string TargetProductName { get; set; } = default!;
    }
}
