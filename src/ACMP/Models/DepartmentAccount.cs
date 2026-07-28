using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class DepartmentAccount
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100006</example>
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Example Ltd.</example>
        [JsonPropertyName("DepartmentName")]
        public string DepartmentName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Vatid</example>
        [JsonPropertyName("VATID")]
        public string? VATID { get; set; }

        [JsonPropertyName("ContractId")]
        public string? ContractId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Westminster blvrd. 1</example>
        [JsonPropertyName("Address")]
        public string? Address { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>City</example>
        [JsonPropertyName("City")]
        public string? City { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Bournemouth</example>
        [JsonPropertyName("State")]
        public string? State { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>United Kingdom</example>
        [JsonPropertyName("Country")]
        public string? Country { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>BH1 1AA</example>
        [JsonPropertyName("Zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>info@example.com</example>
        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>English</example>
        [JsonPropertyName("Language")]
        public string? Language { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>PO Number</example>
        [JsonPropertyName("PurchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>+49 12154878744</example>
        [JsonPropertyName("Phone")]
        public string? Phone { get; set; }
    }
}
