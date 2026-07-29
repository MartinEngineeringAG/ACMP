using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSpecialDealRequest
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }
    }
}
