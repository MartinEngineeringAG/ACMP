using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPFieldsForService")]
    [OutputType(typeof(SubscriptionInputDefinition))]
    public class GetAcmpFieldsForServiceCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetFieldsForServiceRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetFieldsForServiceAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpFieldsForServiceFailed");
            }
        }
    }
}
