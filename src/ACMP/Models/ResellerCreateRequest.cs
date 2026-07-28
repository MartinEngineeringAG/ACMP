using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ResellerCreateRequest
    {
        [JsonPropertyName("resellerAccount")]
        public ResellerCreateRequestResellerAccount ResellerAccount { get; set; } = default!;
    }
}
