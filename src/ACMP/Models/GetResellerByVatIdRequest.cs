using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetResellerByVatIdRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>000000</example>
        [JsonPropertyName("vatId")]
        public string VatId { get; set; } = default!;
    }
}
