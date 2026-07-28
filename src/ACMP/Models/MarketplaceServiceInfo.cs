using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class MarketplaceServiceInfo
    {
        [JsonPropertyName("Charges")]
        public List<MarketplaceServiceChargeInfo>? Charges { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Mailbox Service</example>
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>333_MailboxService_000</example>
        [JsonPropertyName("ServiceId")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2</example>
        [JsonPropertyName("MarketplaceId")]
        public long? MarketplaceId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Active</example>
        [JsonPropertyName("Status")]
        public string? Status { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Microsoft</example>
        [JsonPropertyName("VendorDisplayName")]
        public string? VendorDisplayName { get; set; }
    }
}
