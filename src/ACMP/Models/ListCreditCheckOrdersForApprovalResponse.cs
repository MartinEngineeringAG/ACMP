using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ListCreditCheckOrdersForApprovalResponse
    {
        [JsonPropertyName("Items")]
        public List<CreditCheckInfo> Items { get; set; } = new();
    }
}
