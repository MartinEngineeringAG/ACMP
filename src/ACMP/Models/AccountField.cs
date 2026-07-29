using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class AccountField
    {
        [JsonPropertyName("DefaultValue")]
        public AccountFieldValue? DefaultValue { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("DisplayTemplate")]
        public string? DisplayTemplate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("DisplayType")]
        public FieldDisplayType? DisplayType { get; set; }

        [JsonPropertyName("EnumMembers")]
        public List<AccountFieldValueItem>? EnumMembers { get; set; }

        [JsonPropertyName("Hint")]
        public string? Hint { get; set; }

        [JsonPropertyName("IsList")]
        public bool? IsList { get; set; }

        [JsonPropertyName("IsPartialValidation")]
        public bool? IsPartialValidation { get; set; }

        [JsonPropertyName("IsRemoteValidation")]
        public bool? IsRemoteValidation { get; set; }

        [JsonPropertyName("IsUnique")]
        public bool? IsUnique { get; set; }

        [JsonPropertyName("MaxValue")]
        public Dictionary<string, object?>? MaxValue { get; set; }

        [JsonPropertyName("MinValue")]
        public Dictionary<string, object?>? MinValue { get; set; }

        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Type")]
        public string? Type { get; set; }

        [JsonPropertyName("Validator")]
        public string? Validator { get; set; }

        [JsonPropertyName("CustomProperties")]
        public Dictionary<string, object?>? CustomProperties { get; set; }
    }
}
