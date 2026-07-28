using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Remove, "ACMPMarketplaceServices")]
    [OutputType(typeof(MarketplaceServiceInfo))]
    public class RemoveAcmpMarketplaceServicesCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public DeleteMarketplaceServicesRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.DeleteMarketplaceServicesAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "RemoveAcmpMarketplaceServicesFailed");
            }
        }
    }
}
