using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ACMP.Enums;

namespace ACMP.Models
{
    public class CompanyAccount
    {
        [JsonPropertyName("companyAccount")]
        public CompanyAccountCompanyAccount CompanyAccountPayload { get; set; } = default!;

        /// <summary>
        /// Only necessary for US instance.
        /// </summary>
        /// <example>Alabama</example>
        [JsonPropertyName("State")]
        public string? State { get; set; }

        [JsonPropertyName("CreateDefaultAdminUser")]
        public bool? CreateDefaultAdminUser { get; set; }

        [JsonPropertyName("Industry")]
        public Industry? Industry { get; set; }
    }
}
