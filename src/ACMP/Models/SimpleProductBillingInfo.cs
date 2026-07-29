using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class SimpleProductBillingInfo
    {
        [JsonPropertyName("BillableTimeUnit")]
        public string? BillableTimeUnit { get; set; }

        [JsonPropertyName("ChargeFirstTimeUnit")]
        public bool? ChargeFirstTimeUnit { get; set; }

        [JsonPropertyName("ChargeLastTimeUnit")]
        public bool? ChargeLastTimeUnit { get; set; }

        [JsonPropertyName("AdvancePaymentPeriodInMonths")]
        public decimal? AdvancePaymentPeriodInMonths { get; set; }

        [JsonPropertyName("FieldDisplayName")]
        public string? FieldDisplayName { get; set; }

        [JsonPropertyName("FieldDisplayValue")]
        public string? FieldDisplayValue { get; set; }

        [JsonPropertyName("FieldName")]
        public string? FieldName { get; set; }

        [JsonPropertyName("FieldValue")]
        public string? FieldValue { get; set; }

        [JsonPropertyName("VendorSku")]
        public string? VendorSku { get; set; }

        [JsonPropertyName("MaterialNumber")]
        public string? MaterialNumber { get; set; }
    }
}
