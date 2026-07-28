using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AllProductAccountsWithFieldsReportLine
    {
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        [JsonPropertyName("ResellerAccountId")]
        public long? ResellerAccountId { get; set; }

        [JsonPropertyName("CompanyName")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("ResellerName")]
        public string? ResellerName { get; set; }

        [JsonPropertyName("ResellerCountry")]
        public string? ResellerCountry { get; set; }

        [JsonPropertyName("StartDate")]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Dynamic field names and values returned by the stored procedure for the selected product.
        /// </summary>
        [JsonPropertyName("Fields")]
        public Dictionary<string, object?>? Fields { get; set; }
    }
}
