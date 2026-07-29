using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class InvoiceAggregationResponse
    {
        [JsonPropertyName("InvoiceAggregation")]
        public List<InvoiceAggregationLine>? InvoiceAggregation { get; set; }
    }
}
