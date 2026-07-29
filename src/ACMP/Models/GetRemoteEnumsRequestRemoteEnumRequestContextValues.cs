using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumsRequestRemoteEnumRequestContextValues
    {
        [JsonPropertyName("BillingType")]
        public string? BillingType { get; set; }

        [JsonPropertyName("MicrosoftTenantId")]
        public string? MicrosoftTenantId { get; set; }
    }
}
