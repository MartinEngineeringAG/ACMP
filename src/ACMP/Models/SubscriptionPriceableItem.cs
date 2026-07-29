using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionPriceableItem
    {
        [JsonPropertyName("ChargeType")]
        public string? ChargeType { get; set; }

        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("FieldName")]
        public string? FieldName { get; set; }

        [JsonPropertyName("IsUDRCField")]
        public bool? IsUDRCField { get; set; }

        [JsonPropertyName("PriceableItemDescription")]
        public string? PriceableItemDescription { get; set; }

        [JsonPropertyName("PriceableItemType")]
        public string? PriceableItemType { get; set; }

        [JsonPropertyName("PurchasePrice")]
        public decimal? PurchasePrice { get; set; }

        [JsonPropertyName("SalesPrice")]
        public decimal? SalesPrice { get; set; }

        [JsonPropertyName("SuggestedRetailPrice")]
        public decimal? SuggestedRetailPrice { get; set; }

        [JsonPropertyName("MaterialNumber")]
        public string? MaterialNumber { get; set; }

        [JsonPropertyName("ProductNumber")]
        public string? ProductNumber { get; set; }

        [JsonPropertyName("PrepaidPeriodInMonths")]
        public decimal? PrepaidPeriodInMonths { get; set; }

        [JsonPropertyName("CommitementPeriodInMonths")]
        public decimal? CommitementPeriodInMonths { get; set; }

        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }
    }
}
