using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DependencyInfo
    {
        [JsonPropertyName("DependentProductAdded")]
        public bool? DependentProductAdded { get; set; }

        [JsonPropertyName("IndirectDependencyInfoAccount")]
        public List<IndirectDependencyInfoAccount>? IndirectDependencyInfoAccount { get; set; }

        [JsonPropertyName("ProductDisplayname")]
        public string? ProductDisplayname { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }
    }
}
