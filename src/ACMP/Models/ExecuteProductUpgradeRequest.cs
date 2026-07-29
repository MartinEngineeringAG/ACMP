using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteProductUpgradeRequest
    {
        [JsonPropertyName("sourceAccountId")]
        public long SourceAccountId { get; set; }

        [JsonPropertyName("targetProductName")]
        public string TargetProductName { get; set; } = default!;

        [JsonPropertyName("targetAccountId")]
        public long? TargetAccountId { get; set; }

        [JsonPropertyName("fieldValues")]
        public ExecuteProductUpgradeRequestFieldValues FieldValues { get; set; } = default!;
    }
}
