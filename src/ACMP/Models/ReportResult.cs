using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    [JsonConverter(typeof(ReportResultJsonConverter))]
    public class ReportResult
    {
        [JsonPropertyName("Rows")]
        public List<ReportRow>? Rows { get; set; }

        [JsonPropertyName("Columns")]
        public List<ReportColumn>? Columns { get; set; }
    }
}
