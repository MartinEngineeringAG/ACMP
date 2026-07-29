using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleUpdateRoleUsers
    {
        [JsonPropertyName("roleUsers")]
        public SimpleUpdateRoleUsersRoleUsers RoleUsers { get; set; } = default!;
    }
}
