using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class Report
    {
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Parameters")]
        public List<ReportParameter>? Parameters { get; set; }
    }
}
