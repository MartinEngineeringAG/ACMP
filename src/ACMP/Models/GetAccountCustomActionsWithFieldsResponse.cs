using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetAccountCustomActionsWithFieldsResponse
    {
        [JsonPropertyName("Items")]
        public List<CustomActionDefinition> Items { get; set; } = new();
    }
}
