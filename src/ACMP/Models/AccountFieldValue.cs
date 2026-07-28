using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AccountFieldValue
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>43</example>
        [JsonPropertyName("Value")]
        public Dictionary<string, object?>? Value { get; set; }
    }
}
