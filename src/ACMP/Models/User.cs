using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class User
    {
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("AccountState")]
        public string? AccountState { get; set; }

        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        [JsonPropertyName("FirstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        [JsonPropertyName("Username")]
        public string? Username { get; set; }

        [JsonPropertyName("LastLogon")]
        public string? LastLogon { get; set; }
    }
}
