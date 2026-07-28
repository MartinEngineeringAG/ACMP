using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumsRequestRemoteEnumRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Subscriptionenddatealignment</example>
        [JsonPropertyName("FieldName")]
        public string FieldName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Product_141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("AccountViewName")]
        public string AccountViewName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100003</example>
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Should Always start with Product_
        /// </summary>
        /// <example>1355162</example>
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("DependencyAccountId")]
        public long? DependencyAccountId { get; set; }

        [JsonPropertyName("ContextValues")]
        public GetRemoteEnumsRequestRemoteEnumRequestContextValues? ContextValues { get; set; }
    }
}
