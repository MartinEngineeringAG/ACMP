using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SetSpecialDealRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("specialDeal")]
        public SimpleSpecialDealRequest SpecialDeal { get; set; } = default!;
    }
}
