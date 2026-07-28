using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPSubscriptionFieldsForUpgrade", DefaultParameterSetName = "ByParameter")]
    [OutputType(typeof(PossibleUpgradeRenewFields))]
    public class GetAcmpSubscriptionFieldsForUpgradeCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetProductFieldsForUpgradeRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long AccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string TargetProductName { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest"
                    ? Request
                    : new GetProductFieldsForUpgradeRequest { AccountId = AccountId, TargetProductName = TargetProductName };

                var response = client.GetSubscriptionFieldsForUpgradeAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpSubscriptionFieldsForUpgradeFailed");
            }
        }
    }
}
