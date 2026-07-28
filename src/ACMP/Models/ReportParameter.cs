using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ReportParameter
    {
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Type")]
        public string? Type { get; set; }
    }
}
