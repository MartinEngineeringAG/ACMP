using System;
using System.Management.Automation;

namespace ACMP.Commands
{
    [Cmdlet(VerbsDiagnostic.Test, "ACMPConnection")]
    [OutputType(typeof(bool))]
    public class TestAcmpConnectionCommand : AcmpCmdlet
    {
        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                client.TestConnectionAsync(CancellationToken).GetAwaiter().GetResult();
                WriteObject(true);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "TestAcmpConnectionFailed");
            }
        }
    }
}
