using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetLatestInvoicesResponse
    {
        [JsonPropertyName("Items")]
        public List<Invoice> Items { get; set; } = new();
    }
}
