using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteReportRequestParameters
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2017-04-20</example>
        [JsonPropertyName("enddate")]
        public string? Enddate { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2017-04-25</example>
        [JsonPropertyName("startdate")]
        public string? Startdate { get; set; }
    }
}
