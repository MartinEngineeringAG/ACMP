using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPAccountCustomActionsWithFields")]
    [OutputType(typeof(CustomActionDefinition))]
    public class GetAcmpAccountCustomActionsWithFieldsCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetAccountCustomActionsWithFieldsRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetAccountCustomActionsWithFieldsAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpAccountCustomActionsWithFieldsFailed");
            }
        }
    }
}
