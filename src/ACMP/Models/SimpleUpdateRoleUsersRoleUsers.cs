using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleUpdateRoleUsersRoleUsers
    {
        [JsonPropertyName("Id")]
        public decimal? Id { get; set; }

        [JsonPropertyName("CompanyAccountId")]
        public decimal? CompanyAccountId { get; set; }

        [JsonPropertyName("Users")]
        public List<SimpleUpdateRoleUsersRoleUsersUsersItem>? Users { get; set; }
    }
}
