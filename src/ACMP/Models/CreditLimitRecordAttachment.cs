using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreditLimitRecordAttachment
    {
        [JsonPropertyName("Url")]
        public string? Url { get; set; }

        [JsonPropertyName("Title")]
        public string? Title { get; set; }
    }
}
