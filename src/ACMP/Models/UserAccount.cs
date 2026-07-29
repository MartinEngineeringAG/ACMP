using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UserAccount
    {
        [JsonPropertyName("Email")]
        public string Email { get; set; } = default!;

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; } = default!;

        [JsonPropertyName("LastName")]
        public string LastName { get; set; } = default!;

        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("Username")]
        public string Username { get; set; } = default!;
    }
}
