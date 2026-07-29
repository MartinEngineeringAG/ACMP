using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SubscriptionAccountSubscriptionAccountFields
    {
        [JsonPropertyName("ExistingOffice365customer")]
        public bool? ExistingOffice365Customer { get; set; }

        [JsonPropertyName("MicrosoftpartnerID")]
        public string? MicrosoftpartnerID { get; set; }

        [JsonPropertyName("Phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("PostalCode")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("PrimaryContactEmailAddress")]
        public string? PrimaryContactEmailAddress { get; set; }

        [JsonPropertyName("Verification")]
        public string? Verification { get; set; }

        [JsonPropertyName("Primarycontactfirstname")]
        public string? Primarycontactfirstname { get; set; }

        [JsonPropertyName("Primarycontactlastname")]
        public string? Primarycontactlastname { get; set; }

        [JsonPropertyName("Primarydomainname")]
        public string? Primarydomainname { get; set; }

        [JsonPropertyName("SpecialQualifications")]
        public string? SpecialQualifications { get; set; }
    }
}
