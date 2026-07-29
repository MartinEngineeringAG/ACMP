using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealResponse
    {
        [JsonPropertyName("ChargeStreamId")]
        public long ChargeStreamId { get; set; }

        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        [JsonPropertyName("CompanyDisplayName")]
        public string? CompanyDisplayName { get; set; }

        [JsonPropertyName("CompanyNumericId")]
        public string? CompanyNumericId { get; set; }

        [JsonPropertyName("MarketplaceId")]
        public long? MarketplaceId { get; set; }

        [JsonPropertyName("MarketplaceName")]
        public string? MarketplaceName { get; set; }

        [JsonPropertyName("SellerCompanyAccountId")]
        public long? SellerCompanyAccountId { get; set; }

        [JsonPropertyName("SellerCompanyDisplayName")]
        public string? SellerCompanyDisplayName { get; set; }

        [JsonPropertyName("Comments")]
        public string? Comments { get; set; }

        [JsonPropertyName("RecentActivity")]
        public List<SimpleSpecialDealActivity>? RecentActivity { get; set; }

        [JsonPropertyName("ValidUntil")]
        public string? ValidUntil { get; set; }

        [JsonPropertyName("IsCustomCharge")]
        public bool? IsCustomCharge { get; set; }

        [JsonPropertyName("DiscountItems")]
        public List<SimpleSpecialDealItemResponse>? DiscountItems { get; set; }
    }
}
