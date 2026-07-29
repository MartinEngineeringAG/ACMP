using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class Invoice
    {
        [JsonPropertyName("BillingInterval")]
        public string? BillingInterval { get; set; }

        [JsonPropertyName("Charges")]
        public List<ServiceCharge>? Charges { get; set; }

        [JsonPropertyName("CompanyAccountId")]
        public long? CompanyAccountId { get; set; }

        [JsonPropertyName("CompanyName")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("CustomerId")]
        public string? CustomerId { get; set; }

        [JsonPropertyName("CompanyVatId")]
        public string? CompanyVatId { get; set; }

        [JsonPropertyName("DepartmentName")]
        public string? DepartmentName { get; set; }

        [JsonPropertyName("InvoiceNumber")]
        public string? InvoiceNumber { get; set; }

        [JsonPropertyName("Salesman")]
        public string? Salesman { get; set; }

        [JsonPropertyName("ResellerContractId")]
        public string? ResellerContractId { get; set; }
    }
}
