using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumsRequestRemoteEnumRequest
    {
        [JsonPropertyName("FieldName")]
        public string FieldName { get; set; } = default!;

        [JsonPropertyName("AccountViewName")]
        public string AccountViewName { get; set; } = default!;

        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("DependencyAccountId")]
        public long? DependencyAccountId { get; set; }

        [JsonPropertyName("ContextValues")]
        public GetRemoteEnumsRequestRemoteEnumRequestContextValues? ContextValues { get; set; }
    }
}
