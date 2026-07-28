using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceServiceResponse
    {
        /// <summary>
        /// Items returned by the endpoint.
        /// </summary>
        [JsonPropertyName("Items")]
        public List<MarketplaceServiceInfo> Items { get; set; } = new();
    }
}
