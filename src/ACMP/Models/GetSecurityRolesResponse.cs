using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSecurityRolesResponse
    {
        [JsonPropertyName("Items")]
        public List<SimpleRole> Items { get; set; } = new();
    }
}
