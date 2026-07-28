using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumsRequestRemoteEnumRequestContextValues
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Prepaid (with 1-year commitment) - P1Y</example>
        [JsonPropertyName("BillingType")]
        public string? BillingType { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>3f2b9a1c-7e4d-4bf3-a21f-9c8d5e4b12fa</example>
        [JsonPropertyName("MicrosoftTenantId")]
        public string? MicrosoftTenantId { get; set; }
    }
}
