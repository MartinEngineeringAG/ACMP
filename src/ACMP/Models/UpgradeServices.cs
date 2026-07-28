using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpgradeServices
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>[100001, 100003]</example>
        [JsonPropertyName("ExistingTargetAccounts")]
        public List<long>? ExistingTargetAccounts { get; set; }
    }
}
