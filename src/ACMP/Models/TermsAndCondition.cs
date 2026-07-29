using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class TermsAndCondition
    {
        [JsonPropertyName("Content")]
        public string? Content { get; set; }

        [JsonPropertyName("Title")]
        public string? Title { get; set; }

        [JsonPropertyName("LocalizationLanguageCode")]
        public string? LocalizationLanguageCode { get; set; }

        [JsonPropertyName("DescriptionGroupId")]
        public string? DescriptionGroupId { get; set; }
    }
}
