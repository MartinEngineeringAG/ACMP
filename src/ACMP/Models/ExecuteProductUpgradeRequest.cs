using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteProductUpgradeRequest
    {
        /// <summary>
        /// Account id of the account which should be upgraded.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("sourceAccountId")]
        public long SourceAccountId { get; set; }

        /// <summary>
        /// Technical product name of destination account
        /// </summary>
        /// <example>1429492_NCEMicros365E3_12907</example>
        [JsonPropertyName("targetProductName")]
        public string TargetProductName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100002</example>
        [JsonPropertyName("targetAccountId")]
        public long? TargetAccountId { get; set; }

        /// <summary>
        /// Field name - field value pairs
        /// </summary>
        [JsonPropertyName("fieldValues")]
        public ExecuteProductUpgradeRequestFieldValues FieldValues { get; set; } = default!;
    }
}
