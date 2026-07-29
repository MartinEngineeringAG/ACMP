using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SetSpecialDealRequest
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("specialDeal")]
        public SimpleSpecialDealRequest SpecialDeal { get; set; } = default!;
    }
}
