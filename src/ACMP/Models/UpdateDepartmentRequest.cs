using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class UpdateDepartmentRequest
    {
        [JsonPropertyName("department")]
        public DepartmentUpdate Department { get; set; } = default!;
    }
}
