using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ReportColumn
    {
        [JsonPropertyName("CellIndex")]
        public long? CellIndex { get; set; }

        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Type")]
        public string? Type { get; set; }
    }
}
