using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class RelatedProducts
    {
        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
    }
}
