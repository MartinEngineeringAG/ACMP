using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealItemRequest
    {
        [JsonPropertyName("CustomCharge")]
        public decimal? CustomCharge { get; set; }

        [JsonPropertyName("Discount")]
        public decimal? Discount { get; set; }

        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }
    }
}
