using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class BankDetails
    {
        [JsonPropertyName("IBAN")]
        public string? IBAN { get; set; }

        [JsonPropertyName("BankName")]
        public string? BankName { get; set; }

        [JsonPropertyName("BankIdentifierCode")]
        public string? BankIdentifierCode { get; set; }

        [JsonPropertyName("SWIFTCode")]
        public string? SWIFTCode { get; set; }

        [JsonPropertyName("AccountNumber")]
        public string? AccountNumber { get; set; }

        [JsonPropertyName("AccountName")]
        public string? AccountName { get; set; }

        [JsonPropertyName("BranchCode")]
        public string? BranchCode { get; set; }

        [JsonPropertyName("RegistrationNumber")]
        public string? RegistrationNumber { get; set; }

        [JsonPropertyName("TermsOfPayment")]
        public string? TermsOfPayment { get; set; }
    }
}
