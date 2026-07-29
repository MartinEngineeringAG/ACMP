using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class CompanyGetResponse
    {
        [JsonPropertyName("Address")]
        public string? Address { get; set; }

        [JsonPropertyName("City")]
        public string? City { get; set; }

        [JsonPropertyName("CompanyName")]
        public string? CompanyName { get; set; }

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
        public List<string>? Domain { get; set; }

        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        [JsonPropertyName("Marketplaces")]
        public List<long>? Marketplaces { get; set; }

        [JsonPropertyName("VATID")]
        public string? VATID { get; set; }

        [JsonPropertyName("Zip")]
        public string? Zip { get; set; }

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
        public string? Country { get; set; }

        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        [JsonPropertyName("Marketplace")]
        public long? Marketplace { get; set; }

        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        [JsonPropertyName("Language")]
        public string? Language { get; set; }

        [JsonPropertyName("Industry")]
        public Industry? Industry { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("AccountState")]
        public AccountState? AccountState { get; set; }

        [JsonPropertyName("BillingStartDate")]
        public string? BillingStartDate { get; set; }

        [JsonPropertyName("Currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("OnlineBillSplitByEndCustomer")]
        public bool? OnlineBillSplitByEndCustomer { get; set; }

        [JsonPropertyName("Salesman")]
        public string? Salesman { get; set; }

        [JsonPropertyName("ElectronicInvoicing")]
        public ElectronicInvoicing? ElectronicInvoicing { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("AccountType")]
        public AccountType? AccountType { get; set; }
    }
}
