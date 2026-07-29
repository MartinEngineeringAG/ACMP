using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealActivity
    {
        [JsonPropertyName("Author")]
        public string? Author { get; set; }

        [JsonPropertyName("Comments")]
        public string? Comments { get; set; }

        [JsonPropertyName("CreatedDate")]
        public DateTimeOffset? CreatedDate { get; set; }
    }
}
