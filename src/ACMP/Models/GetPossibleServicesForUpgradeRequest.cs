using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetPossibleServicesForUpgradeRequest
    {
        /// <summary>
        /// Account id of the account which should be upgraded.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }
    }
}
