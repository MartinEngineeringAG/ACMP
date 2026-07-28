using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetResellersRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }
    }
}
