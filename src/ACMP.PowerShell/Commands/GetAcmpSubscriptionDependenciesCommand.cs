using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPSubscriptionDependencies", DefaultParameterSetName = "ByAccountId")]
    [OutputType(typeof(Subscription))]
    public class GetAcmpSubscriptionDependenciesCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetSubscriptionDependenciesRequest Request { get; set; } = default!;

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
                    : new GetSubscriptionDependenciesRequest { AccountId = AccountId, ResellerContext = ResellerContext };

                var response = client.GetSubscriptionDependenciesAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpSubscriptionDependenciesFailed");
            }
        }
    }
}
