using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DepartmentAccount
    {
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        [JsonPropertyName("DepartmentName")]
        public string DepartmentName { get; set; } = default!;

        [JsonPropertyName("VATID")]
        public string? VATID { get; set; }

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        [JsonPropertyName("Address")]
        public string? Address { get; set; }

        [JsonPropertyName("City")]
        public string? City { get; set; }

        [JsonPropertyName("State")]
        public string? State { get; set; }

        [JsonPropertyName("Country")]
        public string? Country { get; set; }

        [JsonPropertyName("Zip")]
        public string? Zip { get; set; }

        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        [JsonPropertyName("Language")]
        public string? Language { get; set; }

        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonPropertyName("Phone")]
        public string? Phone { get; set; }
    }
}
