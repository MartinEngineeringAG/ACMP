using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class TermsAndCondition
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Content of terms and conditions</example>
        [JsonPropertyName("Content")]
        public string? Content { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Title of terms and condition</example>
        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>en</example>
        [JsonPropertyName("LocalizationLanguageCode")]
        public string? LocalizationLanguageCode { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001_CompanyService_TermsAndConditions</example>
        [JsonPropertyName("DescriptionGroupId")]
        public string? DescriptionGroupId { get; set; }
    }
}
