using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Set, "ACMPMarketplaceServiceCharges")]
    [OutputType(typeof(MarketplaceServiceInfo))]
    public class SetAcmpMarketplaceServiceChargesCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public UpdateMarketplaceServiceChargesRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.UpdateMarketplaceServiceChargesAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "SetAcmpMarketplaceServiceChargesFailed");
            }
        }
    }
}
