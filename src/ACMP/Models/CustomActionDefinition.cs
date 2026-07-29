using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CustomActionDefinition
    {
        [JsonPropertyName("ActionName")]
        public string? ActionName { get; set; }

        [JsonPropertyName("ActionDisplayName")]
        public string? ActionDisplayName { get; set; }

        [JsonPropertyName("ActionIcon")]
        public string? ActionIcon { get; set; }

        [JsonPropertyName("Fields")]
        public CustomActionDefinitionFields? Fields { get; set; }

        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }
    }
}
