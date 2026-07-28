using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionInputDefinition
    {
        [JsonPropertyName("Fields")]
        public List<AccountField>? Fields { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }
    }
}
