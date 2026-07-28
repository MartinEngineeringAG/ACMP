using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetPreviewInvoicesRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100002</example>
        [JsonPropertyName("resellerContext")]
        public long? ResellerContext { get; set; }

        [JsonPropertyName("groupByDepartments")]
        public bool? GroupByDepartments { get; set; }
    }
}
