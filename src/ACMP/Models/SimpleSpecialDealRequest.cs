using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealRequest
    {
        [JsonPropertyName("ChargeStreamId")]
        public long ChargeStreamId { get; set; }

        [JsonPropertyName("Comments")]
        public string? Comments { get; set; }

        [JsonPropertyName("IsCustomCharge")]
        public bool? IsCustomCharge { get; set; }

        [JsonPropertyName("ValidUntil")]
        public string ValidUntil { get; set; } = default!;

        [JsonPropertyName("DiscountItems")]
        public List<SimpleSpecialDealItemRequest>? DiscountItems { get; set; }
    }
}
