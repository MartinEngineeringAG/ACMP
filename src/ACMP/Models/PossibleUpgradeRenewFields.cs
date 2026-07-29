using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class PossibleUpgradeRenewFields
    {
        [JsonPropertyName("Fields")]
        public List<UpgradeRenewFields>? Fields { get; set; }
    }
}
