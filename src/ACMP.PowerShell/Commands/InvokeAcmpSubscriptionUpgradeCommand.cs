using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsLifecycle.Invoke, "ACMPSubscriptionUpgrade", DefaultParameterSetName = "ByParameter")]
    [OutputType(typeof(ExecuteSubscriptionUpgradeResponse))]
    public class InvokeAcmpSubscriptionUpgradeCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public ExecuteProductUpgradeRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long SourceAccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string TargetProductName { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNull]
        public ExecuteProductUpgradeRequestFieldValues FieldValues { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter")]
        public long? TargetAccountId { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest"
                    ? Request
                    : new ExecuteProductUpgradeRequest
                    {
                        SourceAccountId = SourceAccountId,
                        TargetProductName = TargetProductName,
                        FieldValues = FieldValues,
                        TargetAccountId = TargetAccountId
                    };

                var response = client.ExecuteSubscriptionUpgradeAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "InvokeAcmpSubscriptionUpgradeFailed");
            }
        }
    }
}
