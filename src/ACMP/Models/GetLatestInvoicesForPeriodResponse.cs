using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetLatestInvoicesForPeriodResponse
    {
        /// <summary>
        /// Items returned by the endpoint.
        /// </summary>
        [JsonPropertyName("Items")]
        public List<Invoice> Items { get; set; } = new();
    }
}
