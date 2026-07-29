using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AllProductAccountsWithFieldsReportResponse
    {
        [JsonPropertyName("AllProductAccountsWithFields")]
        public List<AllProductAccountsWithFieldsReportLine>? AllProductAccountsWithFields { get; set; }
    }
}
