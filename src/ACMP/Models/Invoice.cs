using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class Invoice
    {
        /// <summary>
        /// Code of billing interval
        /// </summary>
        /// <example>01/2021</example>
        [JsonPropertyName("BillingInterval")]
        public string? BillingInterval { get; set; }

        [JsonPropertyName("Charges")]
        public List<ServiceCharge>? Charges { get; set; }

        /// <summary>
        /// AccountId of a customer
        /// </summary>
        /// <example>1234567</example>
        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        /// <summary>
        /// Company name of a customer
        /// </summary>
        /// <example>ACME &amp; Co.</example>
        [JsonPropertyName("CompanyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// NumericID of a customer
        /// </summary>
        /// <example>2000023</example>
        [JsonPropertyName("CustomerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// VATID of a customer
        /// </summary>
        /// <example>FI129191919</example>
        [JsonPropertyName("CompanyVatId")]
        public string? CompanyVatId { get; set; }

        /// <summary>
        /// Department name if SplitByDepartment = true
        /// </summary>
        /// <example>Sales</example>
        [JsonPropertyName("DepartmentName")]
        public string? DepartmentName { get; set; }

        /// <summary>
        /// Unique invoice number
        /// </summary>
        /// <example>80684183</example>
        [JsonPropertyName("InvoiceNumber")]
        public string? InvoiceNumber { get; set; }

        /// <summary>
        /// The company sales manager
        /// </summary>
        /// <example>salesman@example.com</example>
        [JsonPropertyName("Salesman")]
        public string? Salesman { get; set; }

        /// <summary>
        /// Reseller Contract ID
        /// </summary>
        [JsonPropertyName("ResellerContractId")]
        public string? ResellerContractId { get; set; }
    }
}
