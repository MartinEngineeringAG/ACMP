using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    [JsonConverter(typeof(GetMarketplaceServiceChargesResponseJsonConverter))]
    public class GetMarketplaceServiceChargesResponse
    {
        /// <summary>
        /// Marketplace services returned by the endpoint.
        /// </summary>
        public List<MarketplaceServiceInfo> Items { get; set; } = new();
    }
}
