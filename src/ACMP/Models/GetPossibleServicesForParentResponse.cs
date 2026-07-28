using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetPossibleServicesForParentResponse
    {
        /// <summary>
        /// Items returned by the endpoint.
        /// </summary>
        [JsonPropertyName("Items")]
        public List<SimpleProductInfo> Items { get; set; } = new();
    }
}
