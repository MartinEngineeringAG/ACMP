using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ValidateFieldsSubscriptionAccount
    {
        [JsonPropertyName("FieldsToValidate")]
        public List<string>? FieldsToValidate { get; set; }
    }
}
