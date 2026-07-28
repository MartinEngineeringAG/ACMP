using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetInvoiceAggregationReportRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2025</example>
        [JsonPropertyName("year")]
        public long? Year { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>12</example>
        [JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100002</example>
        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }
    }
}
