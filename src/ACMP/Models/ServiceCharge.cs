using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ServiceCharge
    {
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("ActualChargeInterval")]
        public string? ActualChargeInterval { get; set; }

        [JsonPropertyName("BillableParameter")]
        public string? BillableParameter { get; set; }

        [JsonPropertyName("BillingStartDate")]
        public string? BillingStartDate { get; set; }

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("Costs")]
        public decimal? Costs { get; set; }

        [JsonPropertyName("CostsOfUnit")]
        public decimal? CostsOfUnit { get; set; }

        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("VendorReference")]
        public string? VendorReference { get; set; }

        [JsonPropertyName("SecondVendorReference")]
        public string? SecondVendorReference { get; set; }

        [JsonPropertyName("MaterialNumber")]
        public string? MaterialNumber { get; set; }

        [JsonPropertyName("PriceableItemDescription")]
        public string? PriceableItemDescription { get; set; }

        [JsonPropertyName("SalesPrice")]
        public decimal? SalesPrice { get; set; }

        [JsonPropertyName("SalesPriceOfUnit")]
        public decimal? SalesPriceOfUnit { get; set; }

        [JsonPropertyName("ServiceCode")]
        public string? ServiceCode { get; set; }

        [JsonPropertyName("ServiceId")]
        public string? ServiceId { get; set; }

        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }

        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }

        [JsonPropertyName("PriceableItemType")]
        public string? PriceableItemType { get; set; }

        [JsonPropertyName("ProductNumber")]
        public string? ProductNumber { get; set; }

        [JsonPropertyName("UDRCValue")]
        public decimal? UDRCValue { get; set; }

        [JsonPropertyName("VendorName")]
        public string? VendorName { get; set; }

        [JsonPropertyName("SAPInvoiceNumber")]
        public string? SAPInvoiceNumber { get; set; }

        [JsonPropertyName("SAPInvoiceLineNumber")]
        public decimal? SAPInvoiceLineNumber { get; set; }

        [JsonPropertyName("EndCustomerName")]
        public string? EndCustomerName { get; set; }
    }
}
