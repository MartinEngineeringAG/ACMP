using System;
using System.Management.Automation;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommunications.Disconnect, "ACMP")]
    public class DisconnectAcmpCommand : AcmpCmdlet
    {
        protected override void ProcessRecord()
        {
            if (!AcmpSession.TryGetCurrent(out var client) || client is null)
            {
                return;
            }

            try
            {
                client.DisconnectAsync(CancellationToken).GetAwaiter().GetResult();
                AcmpSession.ClearCurrent(dispose: true);
            }
            catch (Exception exception)
            {
                AcmpSession.ClearCurrent(dispose: true);
                ThrowApiError(exception, "DisconnectAcmpFailed");
            }
        }
    }
}
