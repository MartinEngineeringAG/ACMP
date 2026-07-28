using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleRole
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>12</example>
        [JsonPropertyName("Id")]
        public decimal? Id { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("IsShared")]
        public bool? IsShared { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>true</example>
        [JsonPropertyName("IsTemplate")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Administrators</example>
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of users whom this role is assigned to
        /// </summary>
        [JsonPropertyName("Users")]
        public List<SimpleRoleUsersItem>? Users { get; set; }
    }
}
