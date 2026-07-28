using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AllProductAccountsWithFieldsReportRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;

        /// <summary>
        /// The date should be in the past. If a future date is provided, the response will contain no data in AllProductAccountsWithFields.
        /// </summary>
        /// <example>2026-03-01</example>
        [JsonPropertyName("createdBefore")]
        public DateTimeOffset? CreatedBefore { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100002</example>
        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }
    }
}
