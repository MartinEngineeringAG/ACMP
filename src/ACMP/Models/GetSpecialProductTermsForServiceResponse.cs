using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSpecialProductTermsForServiceResponse
    {
        [JsonPropertyName("Items")]
        public List<TermsAndConditions> Items { get; set; } = new();
    }
}
