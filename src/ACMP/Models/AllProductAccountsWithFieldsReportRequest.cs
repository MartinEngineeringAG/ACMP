using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AllProductAccountsWithFieldsReportRequest
    {
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;

        [JsonPropertyName("createdBefore")]
        public DateTimeOffset? CreatedBefore { get; set; }

        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }
    }
}
