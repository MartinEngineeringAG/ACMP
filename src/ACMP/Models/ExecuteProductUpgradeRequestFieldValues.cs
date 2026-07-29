using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ExecuteProductUpgradeRequestFieldValues
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
    }
}
