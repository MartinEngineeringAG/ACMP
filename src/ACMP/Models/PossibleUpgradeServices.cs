using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class PossibleUpgradeServices
    {
        [JsonPropertyName("UpgradeProducts")]
        public List<UpgradeServices>? UpgradeProducts { get; set; }
    }
}
