using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSpecialDealResponse
    {
        [JsonPropertyName("Items")]
        public List<SimpleSpecialDealResponse> Items { get; set; } = new();
    }
}
