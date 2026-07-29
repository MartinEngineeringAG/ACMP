using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CompanyCreateRequest
    {
        [JsonPropertyName("companyAccount")]
        public CompanyCreateRequestCompanyAccount CompanyAccount { get; set; } = default!;
    }
}
