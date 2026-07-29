using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleRoleUsersItem
    {
        [JsonPropertyName("AccountId")]
        public decimal? AccountId { get; set; }

        [JsonPropertyName("Username")]
        public string? Username { get; set; }
    }
}
