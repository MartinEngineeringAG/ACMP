using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetDepartmentsResponse
    {
        [JsonPropertyName("Items")]
        public List<Departments> Items { get; set; } = new();
    }
}
