using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DeleteMarketplaceRequest
    {
        [JsonPropertyName("marketplaceOfferId")]
        public long MarketplaceOfferId { get; set; }
    }
}
