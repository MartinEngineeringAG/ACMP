using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateUserRequest
    {
        [JsonPropertyName("userAccount")]
        public UserAccount UserAccount { get; set; } = default!;
    }
}
