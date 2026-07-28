using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteReportRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>MSCSPSeatChanges</example>
        [JsonPropertyName("reportName")]
        public string ReportName { get; set; } = default!;

        [JsonPropertyName("parameters")]
        public ExecuteReportRequestParameters Parameters { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>["CompanyName", "ServiceName"]</example>
        [JsonPropertyName("columns")]
        public Dictionary<string, object?>? Columns { get; set; }
    }
}
