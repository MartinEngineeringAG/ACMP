using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class UpgradeRenewFields
    {
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("DisplayTemplate")]
        public string? DisplayTemplate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("DisplayType")]
        public FieldDisplayType? DisplayType { get; set; }

        [JsonPropertyName("IsRemoteDatasource")]
        public bool? IsRemoteDatasource { get; set; }

        [JsonPropertyName("Hint")]
        public string? Hint { get; set; }

        [JsonPropertyName("Type")]
        public string? Type { get; set; }

        [JsonPropertyName("Value")]
        public JsonElement? Value { get; set; }

        [JsonPropertyName("AllowedValues")]
        public List<EnumValues>? AllowedValues { get; set; }
    }
}
