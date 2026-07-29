using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetLatestInvoicesRequest
    {
        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }

        [JsonPropertyName("groupByDepartments")]
        public bool? GroupByDepartments { get; set; }
    }
}
