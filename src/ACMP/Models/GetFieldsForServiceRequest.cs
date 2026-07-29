using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetFieldsForServiceRequest
    {
        [JsonPropertyName("parentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = default!;

        [JsonPropertyName("secondaryParentId")]
        public long? SecondaryParentId { get; set; }
    }
}
