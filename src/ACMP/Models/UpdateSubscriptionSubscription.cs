using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class UpdateSubscriptionSubscription
    {
        [JsonPropertyName("AccountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("Fields")]
        public List<UpdateFields> Fields { get; set; } = new();

        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        [JsonPropertyName("ServiceDisplayName")]
        public string? ServiceDisplayName { get; set; }

        [JsonPropertyName("ServiceName")]
        public string ServiceName { get; set; } = default!;

        /// <summary>
        /// Possible Values are "Renew" and "Terminate".
        /// </summary>
        /// <example>Renew</example>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("AdvancePeriodEndAction")]
        public AdvancePeriodEndAction? AdvancePeriodEndAction { get; set; }
    }
}
