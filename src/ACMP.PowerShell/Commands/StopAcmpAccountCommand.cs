using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsLifecycle.Stop, "ACMPAccount")]
    public class StopAcmpAccountCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public TerminateAccountRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                client.TerminateAccountAsync(Request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "StopAcmpAccountFailed");
            }
        }
    }
}
