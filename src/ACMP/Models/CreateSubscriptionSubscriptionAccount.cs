using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateSubscriptionSubscriptionAccount
    {
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("Fields")]
        public Dictionary<string, object?> Fields { get; set; } = new();

        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("DependencyAccountId")]
        public long? DependencyAccountId { get; set; }

        [JsonPropertyName("ServiceName")]
        public string ServiceName { get; set; } = default!;

        [JsonPropertyName("QuoteId")]
        public string? QuoteId { get; set; }

        [JsonPropertyName("ScheduledDate")]
        public string? ScheduledDate { get; set; }
    }
}
