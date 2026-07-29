using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ConfigureSubscriptionRenewRequest
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("fieldValues")]
        public ConfigureSubscriptionRenewRequestFieldValues FieldValues { get; set; } = new();
    }
}
