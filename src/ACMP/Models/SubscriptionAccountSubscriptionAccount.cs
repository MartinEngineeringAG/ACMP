using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionAccountSubscriptionAccount
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>CH31244</example>
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        /// <summary>
        /// Provide only for ValidateFields methode when modifying subscription
        /// </summary>
        /// <example>1413010</example>
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// Provide a list of key value pairs. Fieldname: Value. To determine the field names use the /GetFieldsForService method, the value of the Name key from the /GetFieldsForService method should be used as the field value. Validation should be taken into account. Some fields might have regex validation so important to provide correct values, otherwyse subscription creation will fail.
        /// </summary>
        [JsonPropertyName("Fields")]
        public SubscriptionAccountSubscriptionAccountFields Fields { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("ServiceName")]
        public string ServiceName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>CUSTOM</example>
        [JsonPropertyName("Action")]
        public string? Action { get; set; }
    }
}
