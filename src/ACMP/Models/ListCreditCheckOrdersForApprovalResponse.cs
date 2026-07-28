using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ListCreditCheckOrdersForApprovalResponse
    {
        /// <summary>
        /// Items returned by the endpoint.
        /// </summary>
        [JsonPropertyName("Items")]
        public List<CreditCheckInfo> Items { get; set; } = new();
    }
}
