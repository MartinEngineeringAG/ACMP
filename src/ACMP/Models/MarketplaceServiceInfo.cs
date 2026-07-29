using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class MarketplaceServiceInfo
    {
        [JsonPropertyName("Charges")]
        public List<MarketplaceServiceChargeInfo>? Charges { get; set; }

        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("ServiceId")]
        public string? ServiceId { get; set; }

        [JsonPropertyName("MarketplaceId")]
        public long? MarketplaceId { get; set; }

        [JsonPropertyName("Status")]
        public string? Status { get; set; }

        [JsonPropertyName("VendorDisplayName")]
        public string? VendorDisplayName { get; set; }
    }
}
