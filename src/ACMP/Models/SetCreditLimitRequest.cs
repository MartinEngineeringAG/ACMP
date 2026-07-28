using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SetCreditLimitRequest
    {
        /// <summary>
        /// Company accountId to whom add credit limit
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// Optional. Limit for specific company. If it's empty, credit limit will be removed from specific company.
        /// </summary>
        /// <example>6000.0</example>
        [JsonPropertyName("limit")]
        public decimal? Limit { get; set; }

        /// <summary>
        /// Reason why credit limit is set.
        /// </summary>
        /// <example>credit reason</example>
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = default!;
    }
}
