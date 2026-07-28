using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetFieldsForServiceRequest
    {
        /// <summary>
        /// Account id of the account under which to add the new service. This is necessary since we calculate things like available enum values and default values based on the parent.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// Internal name of the service to add.
        /// </summary>
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;

        /// <summary>
        /// Optional. Some services require secondary parent subscription - I.e. MS Office Subscriptions require MS Tenant subscription as a secondary parent. This is also required (when applicable) to calculate enums and default values.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("secondaryParentId")]
        public long? SecondaryParentId { get; set; }
    }
}
