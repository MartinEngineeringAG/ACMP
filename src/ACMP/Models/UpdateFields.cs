using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateFields
    {
        [JsonPropertyName("displayname")]
        public string? Displayname { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("value")]
        public string Value { get; set; } = default!;
    }
}
