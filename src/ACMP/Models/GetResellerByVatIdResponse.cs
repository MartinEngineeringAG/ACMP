using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetResellerByVatIdResponse
    {
        [JsonPropertyName("Items")]
        public List<ResellerGetResponse> Items { get; set; } = new();
    }
}
