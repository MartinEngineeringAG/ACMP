using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>200001</example>
        [JsonPropertyName("ChargeStreamId")]
        public long ChargeStreamId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Special deal for customer</example>
        [JsonPropertyName("Comments")]
        public string? Comments { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsCustomCharge")]
        public bool? IsCustomCharge { get; set; }

        /// <summary>
        /// Month until which the deal is valid (MM-YYYY)
        /// </summary>
        /// <example>02-2030</example>
        [JsonPropertyName("ValidUntil")]
        public string ValidUntil { get; set; } = default!;

        [JsonPropertyName("DiscountItems")]
        public List<SimpleSpecialDealItemRequest>? DiscountItems { get; set; }
    }
}
