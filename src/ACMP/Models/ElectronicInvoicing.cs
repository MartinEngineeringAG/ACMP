using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ElectronicInvoicing
    {
        [JsonPropertyName("InvoiceCurrency")]
        public string? InvoiceCurrency { get; set; }

        [JsonPropertyName("InvoiceExchangeRate")]
        public string? InvoiceExchangeRate { get; set; }
    }
}
