using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPSubscriptionWithAddons", DefaultParameterSetName = "ByAccountId")]
    [OutputType(typeof(Subscription))]
    public class GetAcmpSubscriptionWithAddonsCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetSubscriptionRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByAccountId", Mandatory = true, Position = 0)]
        public long AccountId { get; set; }

        [Parameter(ParameterSetName = "ByAccountId")]
        public long? ResellerContext { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest"
                    ? Request
                    : new GetSubscriptionRequest { AccountId = AccountId, ResellerContext = ResellerContext };

                var response = client.GetSubscriptionWithAddonsAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpSubscriptionWithAddonsFailed");
            }
        }
    }
}
