using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class CompanyCreateRequestCompanyAccount
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>1 Chapel Hill</example>
        [JsonPropertyName("Address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Bournemouth</example>
        [JsonPropertyName("City")]
        public string City { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Example Ltd.</example>
        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example></example>
        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CrefoNumber")]
        public string? CrefoNumber { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CustomerId")]
        public string? CustomerId { get; set; }

        [JsonPropertyName("BankDetails")]
        public BankDetails? BankDetails { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2027-10-23T00:00:00</example>
        [JsonPropertyName("CompanyContractEndDate")]
        public string? CompanyContractEndDate { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>["example.com", "example.net"]</example>
        [JsonPropertyName("Domain")]
        public List<string> Domain { get; set; } = new();

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>info@example.com</example>
        [JsonPropertyName("Email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>[101, 102]</example>
        [JsonPropertyName("Marketplaces")]
        public List<long> Marketplaces { get; set; } = new();

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>GB999 9999 73</example>
        [JsonPropertyName("VATID")]
        public string? VATID { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>BH1 1AA</example>
        [JsonPropertyName("Zip")]
        public string Zip { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>technical@example.com</example>
        [JsonPropertyName("TechnicalEmail")]
        public string? TechnicalEmail { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>+49 12154878744</example>
        [JsonPropertyName("ContactPhone")]
        public string? ContactPhone { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>account@account.com</example>
        [JsonPropertyName("TehnicalAccountManager")]
        public string? TehnicalAccountManager { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example></example>
        [JsonPropertyName("ReferenceNumber")]
        public string? ReferenceNumber { get; set; }

        /// <summary>
        /// Only necessary for US instance.
        /// </summary>
        /// <example>Alabama</example>
        [JsonPropertyName("State")]
        public string? State { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Robert Robertson</example>
        [JsonPropertyName("TechnicalContact")]
        public string? TechnicalContact { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Joe Johnson</example>
        [JsonPropertyName("ContactPerson")]
        public string? ContactPerson { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>United Kingdom</example>
        [JsonPropertyName("Country")]
        public string Country { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>101</example>
        [JsonPropertyName("Marketplace")]
        public long? Marketplace { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("CreateDefaultAdminUser")]
        public bool? CreateDefaultAdminUser { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>[2, 154]</example>
        [JsonPropertyName("ParentRoleList")]
        public List<long>? ParentRoleList { get; set; }

        [JsonPropertyName("Industry")]
        public Industry? Industry { get; set; }
    }
}
