using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetServiceInformationRequest
    {
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; } = default!;
    }
}
