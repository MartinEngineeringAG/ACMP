using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPAvailableServicesForMarketplace")]
    [OutputType(typeof(SimpleProductInfo))]
    public class GetAcmpAvailableServicesForMarketplaceCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetAvailableServicesForMarketplaceRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetAvailableServicesForMarketplaceAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpAvailableServicesForMarketplaceFailed");
            }
        }
    }
}
