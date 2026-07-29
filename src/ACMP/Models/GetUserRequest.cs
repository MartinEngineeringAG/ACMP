using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetUserRequest
    {
        [JsonPropertyName("accountId")]
        public long? AccountId { get; set; }
    }
}
