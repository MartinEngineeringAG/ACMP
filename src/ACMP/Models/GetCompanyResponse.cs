using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetCompanyResponse
    {
        [JsonPropertyName("Items")]
        public List<CompanyGetResponse> Items { get; set; } = new();
    }
}
