using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPReports")]
    [OutputType(typeof(Report))]
    public class GetAcmpReportsCommand : AcmpCmdlet
    {
        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetReportsAsync(CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpReportsFailed");
            }
        }
    }
}
