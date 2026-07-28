using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateSubscriptionSubscriptionAccount
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>CH31244</example>
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>9876543456</example>
        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Provide service-specific key value pairs. Use /GetFieldsForService to determine valid field names for the selected service.
        /// </summary>
        [JsonPropertyName("Fields")]
        public Dictionary<string, object?> Fields { get; set; } = new();

        /// <summary>
        /// Parent AccountID of new subscription.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// Dependency AccountID when the subscription depends on another service account.
        /// </summary>
        /// <example>100005</example>
        [JsonPropertyName("DependencyAccountId")]
        public long? DependencyAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("ServiceName")]
        public string ServiceName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>b71da242-9f82-49fd-9eec-87a9ff7fe6a4</example>
        [JsonPropertyName("QuoteId")]
        public string? QuoteId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2020-04-30</example>
        [JsonPropertyName("ScheduledDate")]
        public string? ScheduledDate { get; set; }
    }
}
