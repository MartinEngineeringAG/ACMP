using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Add, "ACMPMarketplaceServices")]
    [OutputType(typeof(MarketplaceServiceInfo))]
    public class AddAcmpMarketplaceServicesCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public AddMarketplaceServicesRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.AddMarketplaceServicesAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "AddAcmpMarketplaceServicesFailed");
            }
        }
    }
}
