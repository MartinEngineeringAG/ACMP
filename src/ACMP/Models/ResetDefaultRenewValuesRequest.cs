using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ResetDefaultRenewValuesRequest
    {
        /// <summary>
        /// Subscription account id for which saved renew values should be reset.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }
    }
}
