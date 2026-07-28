using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class RelatedProducts
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001_CompanyService</example>
        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Company Service</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
    }
}
