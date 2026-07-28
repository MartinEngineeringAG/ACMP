using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreditCheckInfo
    {
        [JsonPropertyName("RequestId")]
        public long? RequestId { get; set; }

        [JsonPropertyName("QuoteId")]
        public string? QuoteId { get; set; }

        [JsonPropertyName("CreatedBy")]
        public long? CreatedBy { get; set; }

        [JsonPropertyName("CreatedByDisplayName")]
        public string? CreatedByDisplayName { get; set; }

        [JsonPropertyName("CreationDate")]
        public string? CreationDate { get; set; }

        [JsonPropertyName("MethodName")]
        public decimal? MethodName { get; set; }

        [JsonPropertyName("BillableFields")]
        public Dictionary<string, object?>? BillableFields { get; set; }

        [JsonPropertyName("PayerAccountId")]
        public long? PayerAccountId { get; set; }

        [JsonPropertyName("PayerCompanyName")]
        public string? PayerCompanyName { get; set; }

        [JsonPropertyName("PayerCurrency")]
        public string? PayerCurrency { get; set; }

        [JsonPropertyName("PayerContractId")]
        public string? PayerContractId { get; set; }

        [JsonPropertyName("EndCustomerAccountId")]
        public decimal? EndCustomerAccountId { get; set; }

        [JsonPropertyName("EndCustomerName")]
        public string? EndCustomerName { get; set; }

        [JsonPropertyName("ProductName")]
        public string? ProductName { get; set; }

        [JsonPropertyName("ProductDisplayName")]
        public string? ProductDisplayName { get; set; }

        [JsonPropertyName("ExecutionDate")]
        public string? ExecutionDate { get; set; }

        [JsonPropertyName("ErrorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("CurrentLimit")]
        public decimal? CurrentLimit { get; set; }

        [JsonPropertyName("ProjectedInvoice")]
        public decimal? ProjectedInvoice { get; set; }

        [JsonPropertyName("DailyTransactions")]
        public decimal? DailyTransactions { get; set; }

        [JsonPropertyName("TransactionValue")]
        public decimal? TransactionValue { get; set; }

        [JsonPropertyName("ApprovalStatus")]
        public string? ApprovalStatus { get; set; }

        [JsonPropertyName("StatusDate")]
        public string? StatusDate { get; set; }

        [JsonPropertyName("StatusUpdatedBy")]
        public long? StatusUpdatedBy { get; set; }

        [JsonPropertyName("StatusUpdatedByDisplayName")]
        public string? StatusUpdatedByDisplayName { get; set; }

        [JsonPropertyName("Comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("Attachments")]
        public List<CreditLimitRecordAttachment>? Attachments { get; set; }
    }
}
