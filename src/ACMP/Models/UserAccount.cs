using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UserAccount
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [JsonPropertyName("Email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>John</example>
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Doe</example>
        [JsonPropertyName("LastName")]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("ParentAccountId")]
        public long ParentAccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [JsonPropertyName("Username")]
        public string Username { get; set; } = default!;
    }
}
