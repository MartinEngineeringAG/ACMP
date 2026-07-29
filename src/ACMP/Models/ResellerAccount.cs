using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ResellerAccount
    {
        [JsonPropertyName("resellerAccount")]
        public ResellerAccountResellerAccount ResellerAccountPayload { get; set; } = default!;
    }
}
