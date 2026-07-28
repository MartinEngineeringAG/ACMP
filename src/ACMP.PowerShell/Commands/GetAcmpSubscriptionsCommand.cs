using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPSubscriptions", DefaultParameterSetName = "ByParentAccountId")]
    [OutputType(typeof(Subscription))]
    public class GetAcmpSubscriptionsCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByParentAccountId", Mandatory = true, Position = 0)]
        public long ParentAccountId { get; set; }

        [Parameter(ParameterSetName = "ByParentAccountId")]
        public long? ResellerContext { get; set; }

        [Parameter(ParameterSetName = "ByParentAccountId")]
        public bool? ExcludeUserLevel { get; set; }

        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetSubscriptionsRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = ParameterSetName == "ByRequest"
                    ? client.GetSubscriptionsAsync(Request, CancellationToken).GetAwaiter().GetResult()
                    : client.GetSubscriptionsAsync(
                        new GetSubscriptionsRequest
                        {
                            ParentAccountId = ParentAccountId,
                            ResellerContext = ResellerContext,
                            ExcludeUserLevel = ExcludeUserLevel
                        },
                        CancellationToken).GetAwaiter().GetResult();

                if (response?.Items == null)
                {
                    return;
                }

                foreach (var subscription in response.Items)
                {
                    WriteObject(subscription);
                }
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpSubscriptionsFailed");
            }
        }
    }
}
