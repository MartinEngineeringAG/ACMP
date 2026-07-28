using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Remove, "ACMPMarketplaceService")]
    [OutputType(typeof(MarketplaceServiceInfo))]
    public class RemoveAcmpMarketplaceServiceCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public DeleteMarketplaceServiceRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.DeleteMarketplaceServiceAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "RemoveAcmpMarketplaceServiceFailed");
            }
        }
    }
}
