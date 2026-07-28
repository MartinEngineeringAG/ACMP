using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetLatestInvoicesForPeriodRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2020</example>
        [JsonPropertyName("year")]
        public long Year { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("month")]
        public long Month { get; set; }

        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }

        [JsonPropertyName("groupByDepartments")]
        public bool? GroupByDepartments { get; set; }
    }
}
