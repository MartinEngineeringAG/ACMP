using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateUser
    {
        [JsonPropertyName("user")]
        public UpdateUserUser User { get; set; } = default!;
    }
}
