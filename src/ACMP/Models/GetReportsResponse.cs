using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetReportsResponse
    {
        [JsonPropertyName("Items")]
        public List<Report> Items { get; set; } = new();
    }
}
