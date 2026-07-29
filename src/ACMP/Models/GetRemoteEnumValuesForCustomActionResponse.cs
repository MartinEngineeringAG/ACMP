using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumValuesForCustomActionResponse
    {
        [JsonPropertyName("Items")]
        public List<AccountFieldValueItem> Items { get; set; } = new();
    }
}
