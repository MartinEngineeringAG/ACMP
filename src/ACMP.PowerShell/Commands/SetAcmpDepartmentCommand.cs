using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Set, "ACMPDepartment")]
    public class SetAcmpDepartmentCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public UpdateDepartmentRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                client.UpdateDepartmentAsync(Request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "SetAcmpDepartmentFailed");
            }
        }
    }
}
