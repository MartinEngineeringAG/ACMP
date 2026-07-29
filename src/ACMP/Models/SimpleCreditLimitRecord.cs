using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleCreditLimitRecord
    {
        [JsonPropertyName("Comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("Date")]
        public string? Date { get; set; }

        [JsonPropertyName("Limit")]
        public decimal? Limit { get; set; }

        [JsonPropertyName("RemainingCreditLimit")]
        public decimal? RemainingCreditLimit { get; set; }

        [JsonPropertyName("HasCreditLimit")]
        public bool? HasCreditLimit { get; set; }

        [JsonPropertyName("CreatedByAccountId")]
        public long? CreatedByAccountId { get; set; }

        [JsonPropertyName("IsLocked")]
        public bool? IsLocked { get; set; }
    }
}
