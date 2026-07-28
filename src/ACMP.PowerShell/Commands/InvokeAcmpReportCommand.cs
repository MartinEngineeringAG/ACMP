using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsLifecycle.Invoke, "ACMPReport")]
    [OutputType(typeof(ReportResult))]
    public class InvokeAcmpReportCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public ExecuteReportRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.ExecuteReportAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "InvokeAcmpReportFailed");
            }
        }
    }
}
