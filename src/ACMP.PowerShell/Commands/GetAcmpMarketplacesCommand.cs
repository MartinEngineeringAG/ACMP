using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPMarketplaces")]
    [OutputType(typeof(MarketplaceInfo))]
    public class GetAcmpMarketplacesCommand : AcmpCmdlet
    {
        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetMarketplacesAsync(CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpMarketplacesFailed");
            }
        }
    }
}
