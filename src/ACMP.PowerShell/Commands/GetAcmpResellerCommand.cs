using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPReseller")]
    [OutputType(typeof(ResellerGetResponse))]
    public class GetAcmpResellerCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetResellerRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetResellerAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpResellerFailed");
            }
        }
    }
}
