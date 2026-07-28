using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetPossibleServicesForParentRequest
    {
        /// <summary>
        /// Parent subscription account id. I.e. account id of the company account under which you wish to add new subscription.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }
    }
}
