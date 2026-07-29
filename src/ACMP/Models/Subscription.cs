using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class Subscription
    {
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("AccountState")]
        public AccountState? AccountState { get; set; }

        [JsonPropertyName("Fields")]
        public List<Field>? Fields { get; set; }

        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        [JsonPropertyName("ParentType")]
        public string? ParentType { get; set; }

        [JsonPropertyName("PriceableItems")]
        public List<SubscriptionPriceableItem>? PriceableItems { get; set; }

        [JsonPropertyName("Status")]
        public string? Status { get; set; }

        [UndocumentedApiProperty("Returned by /GetSubscriptions and /GetSubscription, but missing from the OpenAPI Subscription response schema.")]
        [JsonPropertyName("ProvisioningStatus")]
        public string? ProvisioningStatus { get; set; }

        [JsonPropertyName("ErrorDetails")]
        public string? ErrorDetails { get; set; }

        [JsonPropertyName("VendorReferenceId")]
        public string? VendorReferenceId { get; set; }

        [JsonPropertyName("SecondVendorReferenceId")]
        public string? SecondVendorReferenceId { get; set; }

        [JsonPropertyName("ServiceDisplayName")]
        public string? ServiceDisplayName { get; set; }

        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }

        [JsonPropertyName("ContractEndDate")]
        public string? ContractEndDate { get; set; }

        [JsonPropertyName("BillingStartDate")]
        public string? BillingStartDate { get; set; }

        [JsonPropertyName("PriceProtectionEndDate")]
        public string? PriceProtectionEndDate { get; set; }

        [JsonPropertyName("VendorDisplayName")]
        public string? VendorDisplayName { get; set; }

        [JsonPropertyName("ScheduledTerminationDate")]
        public string? ScheduledTerminationDate { get; set; }

        [JsonPropertyName("HasRenewActionValuesConfigured")]
        public bool? HasRenewActionValuesConfigured { get; set; }

        [JsonPropertyName("RemainingCreditLimit")]
        public decimal? RemainingCreditLimit { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("RenewFields")]
        public List<Field>? RenewFields { get; set; }

        [JsonPropertyName("AdvancePeriodEndDate")]
        public string? AdvancePeriodEndDate { get; set; }

        [UndocumentedApiProperty("Returned by /GetSubscriptions and /GetSubscription, but missing from the OpenAPI Subscription response schema.")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("AdvancePeriodEndAction")]
        public AdvancePeriodEndAction? AdvancePeriodEndAction { get; set; }

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("DependencyAccountId")]
        public decimal? DependencyAccountId { get; set; }

        [JsonPropertyName("DependencyServiceName")]
        public string? DependencyServiceName { get; set; }

        [JsonPropertyName("Addons")]
        public SubscriptionAddons? Addons { get; set; }
    }
}
