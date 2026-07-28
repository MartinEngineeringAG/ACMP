using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPResellers")]
    [OutputType(typeof(ResellerGetResponse))]
    public class GetAcmpResellersCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetResellersRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetResellersAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpResellersFailed");
            }
        }
    }
}
