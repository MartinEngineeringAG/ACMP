using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealItemResponse
    {
        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("BasePrice")]
        public decimal? BasePrice { get; set; }

        [JsonPropertyName("CustomCharge")]
        public decimal? CustomCharge { get; set; }

        [JsonPropertyName("Discount")]
        public decimal? Discount { get; set; }

        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }
    }
}
