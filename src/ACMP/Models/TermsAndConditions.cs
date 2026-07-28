using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class TermsAndConditions
    {
        [JsonPropertyName("TermsAndCondition")]
        public List<TermsAndCondition>? TermsAndCondition { get; set; }

        [JsonPropertyName("RelatedProducts")]
        public List<RelatedProducts>? RelatedProducts { get; set; }
    }
}
