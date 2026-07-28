using System;
using System.Management.Automation;
using ACMP.Enums;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Set, "ACMPSubscription", DefaultParameterSetName = "ByParameter")]
    public class SetAcmpSubscriptionCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public UpdateSubscription Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long AccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ServiceName { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNull]
        public UpdateFields[] Fields { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ContractId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? PurchaseOrderNumber { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public long? ParentAccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ServiceDisplayName { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public AdvancePeriodEndAction? AdvancePeriodEndAction { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest" ? Request : BuildRequest();
                client.UpdateSubscriptionAsync(request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "SetAcmpSubscriptionFailed");
            }
        }

        private UpdateSubscription BuildRequest()
        {
            return new UpdateSubscription
            {
                Subscription = new UpdateSubscriptionSubscription
                {
                    AccountId = AccountId,
                    ServiceName = ServiceName,
                    Fields = new System.Collections.Generic.List<UpdateFields>(Fields),
                    ContractId = ContractId,
                    PurchaseOrderNumber = PurchaseOrderNumber,
                    ParentAccountId = ParentAccountId,
                    ServiceDisplayName = ServiceDisplayName,
                    AdvancePeriodEndAction = AdvancePeriodEndAction
                }
            };
        }
    }
}
