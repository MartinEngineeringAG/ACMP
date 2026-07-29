using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CreateDepartmentRequest
    {
        [JsonPropertyName("departmentAccount")]
        public DepartmentAccount DepartmentAccount { get; set; } = default!;
    }
}
