using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ReportResult
    {
        [JsonPropertyName("Rows")]
        public List<ReportRow>? Rows { get; set; }

        [JsonPropertyName("Columns")]
        public List<ReportColumn>? Columns { get; set; }
    }
}
