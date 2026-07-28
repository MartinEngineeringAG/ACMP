using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ValidateFieldsSubscriptionAccount
    {
        /// <summary>
        /// A list of field names to validate. If nothing provided, all fields with validation will be validated
        /// </summary>
        /// <example>["MicrosoftpartnerID", "PrimaryContactEmailAddress"]</example>
        [JsonPropertyName("FieldsToValidate")]
        public List<string>? FieldsToValidate { get; set; }
    }
}
