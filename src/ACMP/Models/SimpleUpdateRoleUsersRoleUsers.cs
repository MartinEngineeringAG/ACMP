using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleUpdateRoleUsersRoleUsers
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
        /// <example>100001</example>
        [JsonPropertyName("CompanyAccountId")]
        public decimal? CompanyAccountId { get; set; }

        /// <summary>
        /// List of users whom this role is assigned to
        /// </summary>
        [JsonPropertyName("Users")]
        public List<SimpleUpdateRoleUsersRoleUsersUsersItem>? Users { get; set; }
    }
}
