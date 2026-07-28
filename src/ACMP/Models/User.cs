using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class User
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100002</example>
        [JsonPropertyName("AccountId")]
        public long? AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Active</example>
        [JsonPropertyName("AccountState")]
        public string? AccountState { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>John</example>
        [JsonPropertyName("FirstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Doe</example>
        [JsonPropertyName("LastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("ParentAccountId")]
        public long? ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [JsonPropertyName("Username")]
        public string? Username { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2020-01-10T06:31:58.46</example>
        [JsonPropertyName("LastLogon")]
        public string? LastLogon { get; set; }
    }
}
