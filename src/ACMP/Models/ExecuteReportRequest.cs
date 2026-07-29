using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteReportRequest
    {
        [JsonPropertyName("reportName")]
        public string ReportName { get; set; } = default!;

        [JsonPropertyName("parameters")]
        public ExecuteReportRequestParameters Parameters { get; set; } = default!;

        [JsonPropertyName("columns")]
        public Dictionary<string, object?>? Columns { get; set; }
    }
}
