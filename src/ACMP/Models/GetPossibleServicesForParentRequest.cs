using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetPossibleServicesForParentRequest
    {
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }
    }
}
