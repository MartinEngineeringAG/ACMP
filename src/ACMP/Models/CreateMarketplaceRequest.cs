using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateMarketplaceRequest
    {
        [JsonPropertyName("marketplaceName")]
        public string? MarketplaceName { get; set; }
    }
}
