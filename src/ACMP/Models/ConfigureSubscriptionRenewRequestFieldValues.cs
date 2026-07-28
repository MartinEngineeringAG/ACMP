using System;
using System.Collections.Generic;

namespace ACMP.Models
{
    /// <summary>
    /// Field name - field value pairs for subscription renew configuration.
    /// </summary>
    /// <remarks>
    /// The OpenAPI schema lists only sample fields, but the live API returns subscription-specific fields like Quantity and BillingType.
    /// </remarks>
    public class ConfigureSubscriptionRenewRequestFieldValues : Dictionary<string, object?>
    {
        public ConfigureSubscriptionRenewRequestFieldValues()
            : base(StringComparer.Ordinal)
        {
        }
    }
}
