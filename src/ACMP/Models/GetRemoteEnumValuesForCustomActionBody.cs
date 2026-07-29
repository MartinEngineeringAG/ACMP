using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumValuesForCustomActionBody
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; } = default!;

        [JsonPropertyName("fieldName")]
        public string FieldName { get; set; } = default!;

        [JsonPropertyName("fieldValues")]
        public Dictionary<string, object?>? FieldValues { get; set; }
    }
}
