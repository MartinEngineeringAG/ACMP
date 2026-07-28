using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class BankDetails
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>IBAN Number</example>
        [JsonPropertyName("IBAN")]
        public string? IBAN { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Bank name</example>
        [JsonPropertyName("BankName")]
        public string? BankName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Bic</example>
        [JsonPropertyName("BankIdentifierCode")]
        public string? BankIdentifierCode { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Swift</example>
        [JsonPropertyName("SWIFTCode")]
        public string? SWIFTCode { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Number</example>
        [JsonPropertyName("AccountNumber")]
        public string? AccountNumber { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Name</example>
        [JsonPropertyName("AccountName")]
        public string? AccountName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Branch</example>
        [JsonPropertyName("BranchCode")]
        public string? BranchCode { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Registration</example>
        [JsonPropertyName("RegistrationNumber")]
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>14 Days</example>
        [JsonPropertyName("TermsOfPayment")]
        public string? TermsOfPayment { get; set; }
    }
}
