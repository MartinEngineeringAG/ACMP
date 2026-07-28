using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetAccountCustomActionsWithFieldsRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100006</example>
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }
    }
}
