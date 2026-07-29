using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetSpecialProductTermsForServiceRequest
    {
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;
    }
}
