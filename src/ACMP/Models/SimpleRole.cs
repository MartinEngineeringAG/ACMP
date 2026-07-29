using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleRole
    {
        [JsonPropertyName("Id")]
        public decimal? Id { get; set; }

        [JsonPropertyName("IsShared")]
        public bool? IsShared { get; set; }

        [JsonPropertyName("IsTemplate")]
        public bool? IsTemplate { get; set; }

        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Users")]
        public List<SimpleRoleUsersItem>? Users { get; set; }
    }
}
