using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSessionTokenResponse
    {
        /// <summary>
        /// Value returned by the endpoint.
        /// </summary>
        /// <example>C9C5MlqrpMwG/6bQ3mAVlm0Z6hi/eh1vsQs4i1I/g==</example>
        [JsonPropertyName("Value")]
        public string Value { get; set; } = default!;
    }
}
