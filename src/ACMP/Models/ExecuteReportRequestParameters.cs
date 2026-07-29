using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteReportRequestParameters
    {
        [JsonPropertyName("enddate")]
        public string? Enddate { get; set; }

        [JsonPropertyName("startdate")]
        public string? Startdate { get; set; }
    }
}
