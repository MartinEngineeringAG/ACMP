using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class IndirectDependencyInfoAccount
    {
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
    }
}
