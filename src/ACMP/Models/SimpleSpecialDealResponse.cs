using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleSpecialDealResponse
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>200001</example>
        [JsonPropertyName("ChargeStreamId")]
        public long ChargeStreamId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>1443961</example>
        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>RitaDemotest</example>
        [JsonPropertyName("CompanyDisplayName")]
        public string? CompanyDisplayName { get; set; }

        /// <summary>
        /// Numeric identifier of the company associated with the charge stream.
        /// </summary>
        /// <example>001443961</example>
        [JsonPropertyName("CompanyNumericId")]
        public string? CompanyNumericId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>29631</example>
        [JsonPropertyName("MarketplaceId")]
        public long? MarketplaceId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>NCE Final SKUs</example>
        [JsonPropertyName("MarketplaceName")]
        public string? MarketplaceName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>1429492</example>
        [JsonPropertyName("SellerCompanyAccountId")]
        public long? SellerCompanyAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Microsoft</example>
        [JsonPropertyName("SellerCompanyDisplayName")]
        public string? SellerCompanyDisplayName { get; set; }

        /// <summary>
        /// General comments provided when the deal was created.
        /// </summary>
        /// <example>Special deal for customer</example>
        [JsonPropertyName("Comments")]
        public string? Comments { get; set; }

        [JsonPropertyName("RecentActivity")]
        public List<SimpleSpecialDealActivity>? RecentActivity { get; set; }

        /// <summary>
        /// Month until which the deal is valid (MM-YYYY).
        /// </summary>
        /// <example>02-2030</example>
        [JsonPropertyName("ValidUntil")]
        public string? ValidUntil { get; set; }

        /// <summary>
        /// When true, CustomCharge is applied to all discount items; when false, Discount percent is applied.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsCustomCharge")]
        public bool? IsCustomCharge { get; set; }

        [JsonPropertyName("DiscountItems")]
        public List<SimpleSpecialDealItemResponse>? DiscountItems { get; set; }
    }
}
