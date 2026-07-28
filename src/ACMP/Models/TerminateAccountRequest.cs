using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class TerminateAccountRequest
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// Applicable only when terminating a service
        /// </summary>
        [JsonPropertyName("terminationReason")]
        public string? TerminationReason { get; set; }
    }
}
