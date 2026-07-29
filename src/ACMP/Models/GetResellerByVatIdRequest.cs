using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetResellerByVatIdRequest
    {
        [JsonPropertyName("vatId")]
        public string VatId { get; set; } = default!;
    }
}
