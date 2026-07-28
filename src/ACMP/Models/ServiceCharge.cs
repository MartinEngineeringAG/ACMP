using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ServiceCharge
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>8787878</example>
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>01.01.2021 - 01.02.2021</example>
        [JsonPropertyName("ActualChargeInterval")]
        public string? ActualChargeInterval { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Billing Type=Monthly Number of CSP licenses=2</example>
        [JsonPropertyName("BillableParameter")]
        public string? BillableParameter { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2020-01-10T06:31:58.46</example>
        [JsonPropertyName("BillingStartDate")]
        public string? BillingStartDate { get; set; }

        /// <summary>
        /// ContractId field value that is set on subscription level
        /// </summary>
        /// <example>00393920329</example>
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        /// <summary>
        /// Subscription purchase order number
        /// </summary>
        /// <example>223321456765</example>
        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// purchase price of subscription
        /// </summary>
        /// <example>5.4</example>
        [JsonPropertyName("Costs")]
        public decimal? Costs { get; set; }

        /// <summary>
        /// purchase price of unit
        /// </summary>
        /// <example>2.7</example>
        [JsonPropertyName("CostsOfUnit")]
        public decimal? CostsOfUnit { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>EUR</example>
        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// External Vendor reference for subscription.
        /// </summary>
        /// <example>1929292-51FK-43SD-M484-DDSAMCXSDLKM</example>
        [JsonPropertyName("VendorReference")]
        public string? VendorReference { get; set; }

        /// <summary>
        /// External Vendor reference for subscription (vendor can make alternative second vendor reference field)
        /// </summary>
        /// <example>x29494:1000:0</example>
        [JsonPropertyName("SecondVendorReference")]
        public string? SecondVendorReference { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>9923929</example>
        [JsonPropertyName("MaterialNumber")]
        public string? MaterialNumber { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Exchange Online (Plan 1) with Billing Type Monthly per unit of NumberofCSPlicenses</example>
        [JsonPropertyName("PriceableItemDescription")]
        public string? PriceableItemDescription { get; set; }

        /// <summary>
        /// sales price of subscription
        /// </summary>
        /// <example>6.2</example>
        [JsonPropertyName("SalesPrice")]
        public decimal? SalesPrice { get; set; }

        /// <summary>
        /// sales price of unit
        /// </summary>
        /// <example>3.1</example>
        [JsonPropertyName("SalesPriceOfUnit")]
        public decimal? SalesPriceOfUnit { get; set; }

        /// <summary>
        /// custom product code
        /// </summary>
        /// <example>ABC10101</example>
        [JsonPropertyName("ServiceCode")]
        public string? ServiceCode { get; set; }

        /// <summary>
        /// internal technical product name of a service
        /// </summary>
        /// <example>103714_ExchangeOnlinePlan1Oct2015_80666</example>
        [JsonPropertyName("ServiceId")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// display name of a service
        /// </summary>
        /// <example>Exchange Online (Plan 1)</example>
        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// Internal id of priceable item
        /// </summary>
        /// <example>1221</example>
        [JsonPropertyName("PriceableItemId")]
        public long? PriceableItemId { get; set; }

        /// <summary>
        /// Type of priceable item
        /// </summary>
        /// <example>Setup</example>
        [JsonPropertyName("PriceableItemType")]
        public string? PriceableItemType { get; set; }

        /// <summary>
        /// Vendor product number (SKU)
        /// </summary>
        /// <example>AAA-06228</example>
        [JsonPropertyName("ProductNumber")]
        public string? ProductNumber { get; set; }

        /// <summary>
        /// If billable item is unit based then it contains amount of units
        /// </summary>
        /// <example>2.0</example>
        [JsonPropertyName("UDRCValue")]
        public decimal? UDRCValue { get; set; }

        /// <summary>
        /// Vendor display name
        /// </summary>
        /// <example>Microsoft</example>
        [JsonPropertyName("VendorName")]
        public string? VendorName { get; set; }

        /// <summary>
        /// Sap Invoice Number
        /// </summary>
        /// <example>SAP Invoice number</example>
        [JsonPropertyName("SAPInvoiceNumber")]
        public string? SAPInvoiceNumber { get; set; }

        /// <summary>
        /// SAP invoice line number
        /// </summary>
        /// <example>1.0</example>
        [JsonPropertyName("SAPInvoiceLineNumber")]
        public decimal? SAPInvoiceLineNumber { get; set; }

        /// <summary>
        /// Name of customer
        /// </summary>
        /// <example>customer name</example>
        [JsonPropertyName("EndCustomerName")]
        public string? EndCustomerName { get; set; }
    }
}
