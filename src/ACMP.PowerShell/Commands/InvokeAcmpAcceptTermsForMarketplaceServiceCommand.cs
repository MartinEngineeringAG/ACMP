using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsLifecycle.Invoke, "ACMPAcceptTermsForMarketplaceService")]
    public class InvokeAcmpAcceptTermsForMarketplaceServiceCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public AcceptTermsForMarketplaceServiceRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                client.AcceptTermsForMarketplaceServiceAsync(Request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "InvokeAcmpAcceptTermsForMarketplaceServiceFailed");
            }
        }
    }
}
