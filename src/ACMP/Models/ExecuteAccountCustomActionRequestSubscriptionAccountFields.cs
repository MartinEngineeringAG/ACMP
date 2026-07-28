using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteAccountCustomActionRequestSubscriptionAccountFields
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("ExistingOffice365customer")]
        public bool? ExistingOffice365Customer { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>12354548</example>
        [JsonPropertyName("MicrosoftpartnerID")]
        public string? MicrosoftpartnerID { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>+49 12154878744</example>
        [JsonPropertyName("Phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2546</example>
        [JsonPropertyName("PostalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>test@test.com</example>
        [JsonPropertyName("PrimaryContactEmailAddress")]
        public string? PrimaryContactEmailAddress { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>2546</example>
        [JsonPropertyName("Verification")]
        public string? Verification { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Max</example>
        [JsonPropertyName("Primarycontactfirstname")]
        public string? Primarycontactfirstname { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>Mustermann</example>
        [JsonPropertyName("Primarycontactlastname")]
        public string? Primarycontactlastname { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>testdomain</example>
        [JsonPropertyName("Primarydomainname")]
        public string? Primarydomainname { get; set; }

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>None</example>
        [JsonPropertyName("SpecialQualifications")]
        public string? SpecialQualifications { get; set; }
    }
}
