using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class CustomActionDefinition
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>CUSTOM</example>
        [JsonPropertyName("ActionName")]
        public string? ActionName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>CUSTOM D</example>
        [JsonPropertyName("ActionDisplayName")]
        public string? ActionDisplayName { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>running-man</example>
        [JsonPropertyName("ActionIcon")]
        public string? ActionIcon { get; set; }

        /// <summary>
        /// Provide a list of key value pairs. Fieldname: Value. To determine the field names use the /GetFieldsForService method, the value of the Name key from the /GetFieldsForService method should be used as the field value. Validation should be taken into account. Some fields might have regex validation so important to provide correct values, otherwyse subscription creation will fail.
        /// </summary>
        [JsonPropertyName("Fields")]
        public CustomActionDefinitionFields? Fields { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>141309_MicrosoftOrganizationtenant_54197</example>
        [JsonPropertyName("ServiceName")]
        public string? ServiceName { get; set; }
    }
}
