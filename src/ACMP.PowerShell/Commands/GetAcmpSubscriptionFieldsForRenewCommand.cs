using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPSubscriptionFieldsForRenew", DefaultParameterSetName = "ByAccountId")]
    [OutputType(typeof(PossibleUpgradeRenewFields))]
    public class GetAcmpSubscriptionFieldsForRenewCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetSubscriptionFieldsForRenewRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByAccountId", Mandatory = true, Position = 0)]
        public long AccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest"
                    ? Request
                    : new GetSubscriptionFieldsForRenewRequest { AccountId = AccountId };

                var response = client.GetSubscriptionFieldsForRenewAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpSubscriptionFieldsForRenewFailed");
            }
        }
    }
}
