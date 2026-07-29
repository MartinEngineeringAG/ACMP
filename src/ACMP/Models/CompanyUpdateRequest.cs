using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CompanyUpdateRequest
    {
        [JsonPropertyName("company")]
        public CompanyUpdateRequestCompany Company { get; set; } = default!;
    }
}
