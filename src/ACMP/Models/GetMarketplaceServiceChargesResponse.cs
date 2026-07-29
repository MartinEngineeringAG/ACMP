using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    [JsonConverter(typeof(GetMarketplaceServiceChargesResponseJsonConverter))]
    public class GetMarketplaceServiceChargesResponse
    {
        public List<MarketplaceServiceInfo> Items { get; set; } = new();
    }
}
