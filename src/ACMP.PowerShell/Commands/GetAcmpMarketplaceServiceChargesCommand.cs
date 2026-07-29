using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPMarketplaceServiceCharges")]
    [OutputType(typeof(MarketplaceServiceInfo))]
    public class GetAcmpMarketplaceServiceChargesCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetMarketplaceServiceChargesRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetMarketplaceServiceChargesAsync(Request, CancellationToken).GetAwaiter().GetResult();
                if (response?.Items is null)
                {
                    return;
                }

                foreach (var marketplaceService in response.Items)
                {
                    WriteObject(marketplaceService);
                }
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpMarketplaceServiceChargesFailed");
            }
        }
    }
}
