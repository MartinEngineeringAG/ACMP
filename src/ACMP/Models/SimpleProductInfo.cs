using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleProductInfo
    {
        [JsonPropertyName("DependencyInfo")]
        public List<DependencyInfo>? DependencyInfo { get; set; }

        [JsonPropertyName("Description")]
        public string? Description { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("Icon")]
        public string? Icon { get; set; }

        [JsonPropertyName("IndirectDependencies")]
        public List<ProductDependency>? IndirectDependencies { get; set; }

        [JsonPropertyName("OwnerName")]
        public string? OwnerName { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("IsTCAccepted")]
        public bool? IsTCAccepted { get; set; }

        [JsonPropertyName("SimpleProductBillingInfo")]
        public List<SimpleProductBillingInfo>? SimpleProductBillingInfo { get; set; }
    }
}
