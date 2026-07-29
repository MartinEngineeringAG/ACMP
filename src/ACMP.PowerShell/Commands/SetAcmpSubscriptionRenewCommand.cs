using System;
using System.Collections;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Set, "ACMPSubscriptionRenew", DefaultParameterSetName = "ByParameter")]
    public class SetAcmpSubscriptionRenewCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public ConfigureSubscriptionRenewRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long AccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNull]
        public Hashtable FieldValues { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest" ? Request : BuildRequest();
                client.ConfigureSubscriptionRenewAsync(request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "SetAcmpSubscriptionRenewFailed");
            }
        }

        private ConfigureSubscriptionRenewRequest BuildRequest()
        {
            var fieldValues = new ConfigureSubscriptionRenewRequestFieldValues();
            foreach (DictionaryEntry entry in FieldValues)
            {
                fieldValues[(string)entry.Key] = entry.Value;
            }

            return new ConfigureSubscriptionRenewRequest
            {
                AccountId = AccountId,
                FieldValues = fieldValues
            };
        }
    }
}
