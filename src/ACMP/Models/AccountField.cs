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

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Primary domain name</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>TextBox</example>
        [JsonPropertyName("DisplayTemplate")]
        public string? DisplayTemplate { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Mandatory</example>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("DisplayType")]
        public FieldDisplayType? DisplayType { get; set; }

        [JsonPropertyName("EnumMembers")]
        public List<AccountFieldValueItem>? EnumMembers { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Please ensure Microsoft domain &lt;DomainName&gt;.onmicrosoft.com is available before ordering! Your client will use it to sign in to Microsoft Cloud services. Only letters and numbers are allowed. No hyphens, periods or underscores.</example>
        [JsonPropertyName("Hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsList")]
        public bool? IsList { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsPartialValidation")]
        public bool? IsPartialValidation { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsRemoteValidation")]
        public bool? IsRemoteValidation { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsUnique")]
        public bool? IsUnique { get; set; }

        [JsonPropertyName("MaxValue")]
        public Dictionary<string, object?>? MaxValue { get; set; }

        [JsonPropertyName("MinValue")]
        public Dictionary<string, object?>? MinValue { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Primarydomainname</example>
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>string</example>
        [JsonPropertyName("Type")]
        public string? Type { get; set; }

        /// <summary>
        /// A regexp that should be used to validate input in this field.
        /// </summary>
        /// <example>[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}</example>
        [JsonPropertyName("Validator")]
        public string? Validator { get; set; }

        /// <summary>
        /// An array of custom properties with key value
        /// </summary>
        [JsonPropertyName("CustomProperties")]
        public Dictionary<string, object?>? CustomProperties { get; set; }
    }
}
