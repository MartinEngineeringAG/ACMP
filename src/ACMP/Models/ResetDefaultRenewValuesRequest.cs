using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ResetDefaultRenewValuesRequest
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }
    }
}
