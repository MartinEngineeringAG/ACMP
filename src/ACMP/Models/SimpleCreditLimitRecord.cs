using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleCreditLimitRecord
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>credit limit reason</example>
        [JsonPropertyName("Comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>EUR</example>
        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2020-01-03T11:22:33.456</example>
        [JsonPropertyName("Date")]
        public string? Date { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>600.0</example>
        [JsonPropertyName("Limit")]
        public decimal? Limit { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>400.0</example>
        [JsonPropertyName("RemainingCreditLimit")]
        public decimal? RemainingCreditLimit { get; set; }

        [JsonPropertyName("HasCreditLimit")]
        public bool? HasCreditLimit { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100002</example>
        [JsonPropertyName("CreatedByAccountId")]
        public long? CreatedByAccountId { get; set; }

        [JsonPropertyName("IsLocked")]
        public bool? IsLocked { get; set; }
    }
}
