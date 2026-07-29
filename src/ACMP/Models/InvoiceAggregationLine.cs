using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class InvoiceAggregationLine
    {
        [JsonPropertyName("Company")]
        public string? Company { get; set; }

        [JsonPropertyName("CustomerId")]
        public string? CustomerId { get; set; }

        [JsonPropertyName("CustomerVatId")]
        public string? CustomerVatId { get; set; }

        [JsonPropertyName("EndCustomerCompanyId")]
        public long? EndCustomerCompanyId { get; set; }

        [JsonPropertyName("EndCustomerCompany")]
        public string? EndCustomerCompany { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("Vendor")]
        public string? Vendor { get; set; }

        [JsonPropertyName("VendorReference")]
        public string? VendorReference { get; set; }

        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("PriceableItemDescription")]
        public string? PriceableItemDescription { get; set; }

        [JsonPropertyName("MaterialNumber")]
        public string? MaterialNumber { get; set; }

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("ResellerContractId")]
        public string? ResellerContractId { get; set; }

        [JsonPropertyName("BillingStartDate")]
        public DateTimeOffset? BillingStartDate { get; set; }

        [JsonPropertyName("ActualChargeInterval")]
        public string? ActualChargeInterval { get; set; }

        [JsonPropertyName("DaysBilled")]
        public long? DaysBilled { get; set; }

        [JsonPropertyName("BillingInterval")]
        public string? BillingInterval { get; set; }

        [JsonPropertyName("BillableParameters")]
        public string? BillableParameters { get; set; }

        [JsonPropertyName("Costs")]
        public decimal? Costs { get; set; }

        [JsonPropertyName("SalesPrice")]
        public decimal? SalesPrice { get; set; }

        [JsonPropertyName("CostsOfUnit")]
        public decimal? CostsOfUnit { get; set; }

        [JsonPropertyName("SalesPriceOfUnit")]
        public decimal? SalesPriceOfUnit { get; set; }

        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("ProductCode")]
        public string? ProductCode { get; set; }

        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }

        [JsonPropertyName("ProductNumber")]
        public string? ProductNumber { get; set; }

        [JsonPropertyName("SalesManager")]
        public string? SalesManager { get; set; }

        [JsonPropertyName("SecondVendorReference")]
        public string? SecondVendorReference { get; set; }

        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        [JsonPropertyName("InvoiceReference")]
        public string? InvoiceReference { get; set; }

        [JsonPropertyName("InvoiceLineNumber")]
        public long? InvoiceLineNumber { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("DepartmentName")]
        public string? DepartmentName { get; set; }

        [JsonPropertyName("UdrcValue")]
        public decimal? UdrcValue { get; set; }

        [JsonPropertyName("PriceableItemType")]
        public string? PriceableItemType { get; set; }

        [JsonPropertyName("DepartmentVatId")]
        public string? DepartmentVatId { get; set; }

        [JsonPropertyName("ServiceId")]
        public string? ServiceId { get; set; }
    }
}
