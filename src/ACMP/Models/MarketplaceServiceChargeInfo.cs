using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class MarketplaceServiceChargeInfo
    {
        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }

        [JsonPropertyName("PriceableItem")]
        public string? PriceableItem { get; set; }

        [JsonPropertyName("PriceableItemType")]
        public string? PriceableItemType { get; set; }

        [JsonPropertyName("ChargeType")]
        public string? ChargeType { get; set; }

        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("PurchasePrice")]
        public decimal? PurchasePrice { get; set; }

        [JsonPropertyName("SuggestedRetailPrice")]
        public decimal? SuggestedRetailPrice { get; set; }

        [JsonPropertyName("CustomPrice")]
        public decimal? CustomPrice { get; set; }

        [JsonPropertyName("PreviousCustomPrice")]
        public decimal? PreviousCustomPrice { get; set; }

        [JsonPropertyName("MaterialNumber")]
        public string? MaterialNumber { get; set; }

        [JsonPropertyName("ProductNumber")]
        public string? ProductNumber { get; set; }
    }
}
