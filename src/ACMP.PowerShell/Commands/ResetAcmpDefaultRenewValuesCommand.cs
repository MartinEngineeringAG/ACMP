using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Reset, "ACMPDefaultRenewValues")]
    public class ResetAcmpDefaultRenewValuesCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public ResetDefaultRenewValuesRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                client.ResetDefaultRenewValuesAsync(Request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "ResetAcmpDefaultRenewValuesFailed");
            }
        }
    }
}
