using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ProductDependency
    {
        [JsonPropertyName("ParentFieldName")]
        public string? ParentFieldName { get; set; }

        [JsonPropertyName("ParentFieldValue")]
        public string? ParentFieldValue { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }
    }
}
