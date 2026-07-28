using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPRemoteEnumValuesForCustomAction")]
    [OutputType(typeof(AccountFieldValueItem))]
    public class GetAcmpRemoteEnumValuesForCustomActionCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetRemoteEnumValuesForCustomActionBody Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.GetRemoteEnumValuesForCustomActionAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpRemoteEnumValuesForCustomActionFailed");
            }
        }
    }
}
