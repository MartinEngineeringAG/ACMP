using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetCompaniesResponse
    {
        [JsonPropertyName("Items")]
        public List<CompanyGetResponse> Items { get; set; } = new();
    }
}
