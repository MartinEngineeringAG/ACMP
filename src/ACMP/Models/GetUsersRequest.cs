using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetUsersRequest
    {
        [JsonPropertyName("companyAccountId")]
        public long CompanyAccountId { get; set; }
    }
}
