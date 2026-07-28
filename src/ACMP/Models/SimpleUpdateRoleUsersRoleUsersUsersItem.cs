using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleUpdateRoleUsersRoleUsersUsersItem
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>100001</example>
        [JsonPropertyName("AccountId")]
        public decimal? AccountId { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>admin@example.com</example>
        [JsonPropertyName("Username")]
        public string? Username { get; set; }
    }
}
