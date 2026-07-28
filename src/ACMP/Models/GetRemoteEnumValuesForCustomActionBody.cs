using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumValuesForCustomActionBody
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>ACTIONNAME</example>
        [JsonPropertyName("action")]
        public string Action { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>RemoteField</example>
        [JsonPropertyName("fieldName")]
        public string FieldName { get; set; } = default!;

        [JsonPropertyName("fieldValues")]
        public Dictionary<string, object?>? FieldValues { get; set; }
    }
}
