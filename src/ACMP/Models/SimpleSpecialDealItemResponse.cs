using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealItemResponse
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>EUR</example>
        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Base price of the priceable item before any special deal.
        /// </summary>
        /// <example>9.99</example>
        [JsonPropertyName("BasePrice")]
        public decimal? BasePrice { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>25.0</example>
        [JsonPropertyName("CustomCharge")]
        public decimal? CustomCharge { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>10.0</example>
        [JsonPropertyName("Discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>300001</example>
        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }
    }
}
