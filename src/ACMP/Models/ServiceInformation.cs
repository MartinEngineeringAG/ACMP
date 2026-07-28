using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ServiceInformation
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Service Name</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Service Description</example>
        [JsonPropertyName("Description")]
        public string? Description { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Service Terms &amp; Conditions</example>
        [JsonPropertyName("TermsConditions")]
        public string? TermsConditions { get; set; }
    }
}
