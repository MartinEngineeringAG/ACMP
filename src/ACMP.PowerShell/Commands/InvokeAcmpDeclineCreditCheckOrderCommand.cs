using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsLifecycle.Invoke, "ACMPDeclineCreditCheckOrder")]
    public class InvokeAcmpDeclineCreditCheckOrderCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public CreditCheckInfo Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                client.DeclineCreditCheckOrderAsync(Request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "InvokeAcmpDeclineCreditCheckOrderFailed");
            }
        }
    }
}
