using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPAllProductAccountsWithFieldsReport")]
    [OutputType(typeof(AllProductAccountsWithFieldsReportResponse))]
    public class GetAcmpAllProductAccountsWithFieldsReportCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public AllProductAccountsWithFieldsReportRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetAllProductAccountsWithFieldsReportAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpAllProductAccountsWithFieldsReportFailed");
            }
        }
    }
}
