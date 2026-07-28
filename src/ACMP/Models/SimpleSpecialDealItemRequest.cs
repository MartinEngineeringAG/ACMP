using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealItemRequest
    {
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
