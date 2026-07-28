using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetCompanyByVatIdResponse
    {
        /// <summary>
        /// Items returned by the endpoint.
        /// </summary>
        [JsonPropertyName("Items")]
        public List<CompanyGetResponse> Items { get; set; } = new();
    }
}
