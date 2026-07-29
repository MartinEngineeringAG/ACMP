using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetLatestInvoicesForPeriodRequest
    {
        [JsonPropertyName("year")]
        public long Year { get; set; }

        [JsonPropertyName("month")]
        public long Month { get; set; }

        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }

        [JsonPropertyName("groupByDepartments")]
        public bool? GroupByDepartments { get; set; }
    }
}
