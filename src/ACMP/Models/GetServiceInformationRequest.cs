using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetServiceInformationRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>name</example>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; } = default!;
    }
}
