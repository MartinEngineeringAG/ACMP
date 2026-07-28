using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ElectronicInvoicing
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>EUR</example>
        [JsonPropertyName("InvoiceCurrency")]
        public string? InvoiceCurrency { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>1.1</example>
        [JsonPropertyName("InvoiceExchangeRate")]
        public string? InvoiceExchangeRate { get; set; }
    }
}
