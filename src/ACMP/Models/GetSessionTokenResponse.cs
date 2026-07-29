using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSessionTokenResponse
    {
        [JsonPropertyName("Value")]
        public string Value { get; set; } = default!;
    }
}
