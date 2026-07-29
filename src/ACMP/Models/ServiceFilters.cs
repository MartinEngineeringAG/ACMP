using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ServiceFilters
    {
        [JsonPropertyName("OwnerAccountIds")]
        public List<long>? OwnerAccountIds { get; set; }

        [JsonPropertyName("ServiceCategories")]
        public List<string>? ServiceCategories { get; set; }

        [JsonPropertyName("ServiceTags")]
        public List<string>? ServiceTags { get; set; }

        [JsonPropertyName("ServiceGroups")]
        public List<string>? ServiceGroups { get; set; }

        [JsonPropertyName("PriceableItemIds")]
        public List<long>? PriceableItemIds { get; set; }
    }
}
