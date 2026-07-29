using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPCreditCheckOrdersForApproval")]
    [OutputType(typeof(CreditCheckInfo))]
    public class GetAcmpCreditCheckOrdersForApprovalCommand : AcmpCmdlet
    {
        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.ListCreditCheckOrdersForApprovalAsync(CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpCreditCheckOrdersForApprovalFailed");
            }
        }
    }
}
