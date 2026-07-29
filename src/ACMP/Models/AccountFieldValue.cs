using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AccountFieldValue
    {
        [JsonPropertyName("Value")]
        public Dictionary<string, object?>? Value { get; set; }
    }
}
