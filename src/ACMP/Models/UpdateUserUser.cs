using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateUserUser
    {
        [JsonPropertyName("AccountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; } = default!;

        [JsonPropertyName("LastName")]
        public string LastName { get; set; } = default!;
    }
}
