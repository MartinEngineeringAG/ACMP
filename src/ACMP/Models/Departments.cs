using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class Departments
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100006</example>
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Active</example>
        [JsonPropertyName("AccountState")]
        public string? AccountState { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Example Ltd.</example>
        [JsonPropertyName("DepartmentName")]
        public string? DepartmentName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>GB999 9999 73</example>
        [JsonPropertyName("VATID")]
        public string? VATID { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>["example.com", "example.net"]</example>
        [JsonPropertyName("CompanyDomain")]
        public List<string>? CompanyDomain { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2017-01-03T11:22:33.456</example>
        [JsonPropertyName("BillingStartDate")]
        public string? BillingStartDate { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example></example>
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>1 Chapel Hill</example>
        [JsonPropertyName("Address")]
        public string? Address { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Bournemouth</example>
        [JsonPropertyName("City")]
        public string? City { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>United Kingdom</example>
        [JsonPropertyName("Country")]
        public string? Country { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>BH1 1AA</example>
        [JsonPropertyName("Zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>info@example.com</example>
        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>GB999 9999 73</example>
        [JsonPropertyName("VAT")]
        public string? VAT { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>en</example>
        [JsonPropertyName("Language")]
        public string? Language { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>+49 12154878744</example>
        [JsonPropertyName("Phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>PO Number</example>
        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Only necessary for US instance.
        /// </summary>
        /// <example>Alabama</example>
        [JsonPropertyName("State")]
        public string? State { get; set; }
    }
}
