using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetResellerRequest
    {
        [JsonPropertyName("accountId")]
        public long? AccountId { get; set; }
    }
}
