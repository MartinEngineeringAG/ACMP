using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPPossibleServicesForUpgrade")]
    [OutputType(typeof(PossibleUpgradeServices))]
    public class GetAcmpPossibleServicesForUpgradeCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetPossibleServicesForUpgradeRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetPossibleServicesForUpgradeAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpPossibleServicesForUpgradeFailed");
            }
        }
    }
}
