using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteSpecialDealRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>200001</example>
        [JsonPropertyName("chargeStreamId")]
        public long ChargeStreamId { get; set; }
    }
}
