using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ResellerCreateRequestResellerAccount
    {
        [JsonPropertyName("Address")]
        public string Address { get; set; } = default!;

        [JsonPropertyName("City")]
        public string City { get; set; } = default!;

        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; } = default!;

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("CrefoNumber")]
        public string? CrefoNumber { get; set; }

        [JsonPropertyName("CustomerId")]
        public string? CustomerId { get; set; }

        [JsonPropertyName("BankDetails")]
        public BankDetails? BankDetails { get; set; }

        [JsonPropertyName("CompanyContractEndDate")]
        public string? CompanyContractEndDate { get; set; }

        [JsonPropertyName("Domain")]
        public List<string> Domain { get; set; } = new();

        [JsonPropertyName("Email")]
        public string Email { get; set; } = default!;

        [JsonPropertyName("Marketplaces")]
        public List<long> Marketplaces { get; set; } = new();

        [JsonPropertyName("VATID")]
        public string? VATID { get; set; }

        [JsonPropertyName("Zip")]
        public string Zip { get; set; } = default!;

        [JsonPropertyName("TechnicalEmail")]
        public string? TechnicalEmail { get; set; }

        [JsonPropertyName("ContactPhone")]
        public string? ContactPhone { get; set; }

        [JsonPropertyName("TehnicalAccountManager")]
        public string? TehnicalAccountManager { get; set; }

        [JsonPropertyName("ReferenceNumber")]
        public string? ReferenceNumber { get; set; }

        [JsonPropertyName("State")]
        public string? State { get; set; }

        [JsonPropertyName("TechnicalContact")]
        public string? TechnicalContact { get; set; }

        [JsonPropertyName("ContactPerson")]
        public string? ContactPerson { get; set; }

        [JsonPropertyName("Country")]
        public string Country { get; set; } = default!;

        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("Marketplace")]
        public long? Marketplace { get; set; }

        [JsonPropertyName("CreateDefaultMarketplace")]
        public bool? CreateDefaultMarketplace { get; set; }

        [JsonPropertyName("CreateDefaultAdminUser")]
        public bool? CreateDefaultAdminUser { get; set; }

        [JsonPropertyName("ParentRoleList")]
        public List<long>? ParentRoleList { get; set; }

        [JsonPropertyName("MPNId")]
        public string? MPNId { get; set; }
    }
}
