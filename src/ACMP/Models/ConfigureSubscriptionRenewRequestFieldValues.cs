using System;
using System.Collections.Generic;

namespace ACMP.Models
{
    public class ConfigureSubscriptionRenewRequestFieldValues : Dictionary<string, object?>
    {
        public ConfigureSubscriptionRenewRequestFieldValues()
            : base(StringComparer.Ordinal)
        {
        }
    }
}
